/*
 -------------------------------------------------------------------------------
 GrFinger Sample
 (c) 2005 - 2010 Griaule Biometrics Ltda.
 http://www.griaulebiometrics.com
 -------------------------------------------------------------------------------

 This sample is provided with "GrFinger Fingerprint Recognition Library" and
 can't run without it. It's provided just as an example of using GrFinger
 Fingerprint Recognition Library and should not be used as basis for any
 commercial product.

 Griaule Biometrics makes no representations concerning either the merchantability
 of this software or the suitability of this sample for any particular purpose.

 THIS SAMPLE IS PROVIDED BY THE AUTHOR "AS IS" AND ANY EXPRESS OR
 IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 IN NO EVENT SHALL GRIAULE BE LIABLE FOR ANY DIRECT, INDIRECT,
 INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
 NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
 DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
 THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
 THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

 You can download the trial version of GrFinger directly from Griaule website.
                                                                   
 These notices must be retained in any copies of any part of this
 documentation and/or sample.

 -------------------------------------------------------------------------------
*/

// -----------------------------------------------------------------------------------
// Database routines
// -----------------------------------------------------------------------------------

using System;
using System.Data;
using System.Data.OleDb;
using GrFingerXLib;
using System.Runtime.InteropServices;
using System.Data.Odbc;
using MySql.Data.MySqlClient;

// the template class
public class TTemplate
{
	// Template data.
	public System.Array _tpt;
	// Template size
	public int _size;

	public TTemplate(){
		// Create a byte buffer for the template
	   _tpt = new byte[(int)GRConstants.GR_MAX_SIZE_TEMPLATE];
	   _size = 0;
	}
}

// the database class
public class DBClass{

    public string table = "huella";
    public string field = "huella";

	// the connection object
    private MySqlConnection _connection;

	// temporary template for retrieving data from DB
	private TTemplate tptBlob;
	
	// the database we'll be connecting to
	//public readonly string CONNECTION_STRING = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\DB\\GrFingerSample.mdb";
    public readonly string CONNECTION_STRING = "Database=panchita_proceso;Data Source=localhost;User Id=root;";
	
	public DBClass(){
	}

	// Open connection
	public bool openDB()
	{
        _connection = new MySqlConnection(CONNECTION_STRING);
		try{
			_connection.Open();
		}
		catch{
			return false;
		}
		tptBlob = new TTemplate();
		return true;
	}//END

	// Close conection
	public bool closeDB()
	{
		if(_connection.State != ConnectionState.Closed)
		  _connection.Close();  
		return true;
	}

	// Clear database
	public bool clearDB()
	{
        MySqlCommand cmdClear = null;
        cmdClear = new MySqlCommand("DELETE FROM " + table, _connection);

		// run "clear" query
		if(_connection.State == ConnectionState.Open)
			cmdClear.ExecuteNonQuery();
		
		return true;
	}


	// Add template to database. Returns added template ID.
	public bool addTemplate(TTemplate tpt,ref int id) 
	{
        MySqlCommand cmdInsert = null;
        MySqlCommand cmdSelect = null;

		try{
			// Create SQL command containing ? parameter for BLOB.
            cmdInsert = new MySqlCommand("INSERT INTO " + table + "(" + field + ") values(?field) ", _connection);
			// Create parameter for ? contained in the SQL statement.
			System.Byte [] temp = new System.Byte[tpt._size + 1];
			System.Array.Copy(tpt._tpt, 0, temp, 0, tpt._size);
            cmdInsert.Parameters.AddWithValue("?field", temp);
            
			//execute query
            if (_connection.State == ConnectionState.Open)
            {
                cmdInsert.Prepare();
                cmdInsert.ExecuteNonQuery();
            }
		}
		catch{
			return false;
		}

		try{
			// Create SQL command containing ? parameter for BLOB.
            cmdSelect = new MySqlCommand("SELECT ID FROM " + table + " ORDER BY ID DESC limit 1", _connection);
		    
			id = System.Convert.ToInt32(cmdSelect.ExecuteScalar());
		}
		catch {
			return false;  
		}

		return true;
	}

	// Returns an OleDbDataReader with all enrolled templates from database.
	public MySqlDataReader  getTemplates()
	{
        MySqlCommand cmdGetTemplates;
        MySqlDataReader rs;

		//setting up command 
        cmdGetTemplates = new MySqlCommand("SELECT * FROM " + table, _connection);
		rs = cmdGetTemplates.ExecuteReader();

		return rs;
	}

	
	// Returns template with the supplied ID.
	public TTemplate getTemplate(int id)
	{
		MySqlCommand cmd = null;
        MySqlDataReader dr = null;
		tptBlob._size = 0;
		try
		{
            cmd = new MySqlCommand(System.String.Concat("SELECT * FROM " + table + " WHERE ID = ", System.Convert.ToString((int)id)), _connection);
			dr = cmd.ExecuteReader();
			// Get query response
			dr.Read();
			getTemplate(dr);
			dr.Close();
		}
		catch{
			dr.Close();
		}
		return tptBlob;
	}

	// Return template data from an OleDbDataReader
    public TTemplate getTemplate(MySqlDataReader rs)
	{
		long readedBytes; 
		tptBlob._size = 0;
		// alloc space
		System.Byte[] temp = new System.Byte[
			(int)GRConstants.GR_MAX_SIZE_TEMPLATE];
		// get bytes
		readedBytes = rs.GetBytes(1, 0, temp, 0,temp.Length);
		// copy to structure
		System.Array.Copy(temp, 0, tptBlob._tpt,0,(int)readedBytes);
		// set real size
		tptBlob._size = (int)readedBytes;

		return tptBlob;
	}

	// Return enrollment ID from an OleDbDataReader
    public int getId(MySqlDataReader rs)
	{
		return rs.GetInt32(0);
	}
}
