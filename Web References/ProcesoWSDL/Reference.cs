﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.1008
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.1008.
// 
#pragma warning disable 1591

namespace Panchita.ProcesoWSDL {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ProcesoWSDLBinding", Namespace="urn:ProcesoWDSL")]
    public partial class ProcesoWSDL : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback WebserviceobtenerPedidosOperationCompleted;
        
        private System.Threading.SendOrPostCallback WebserviceguardarPedidosOperationCompleted;
        
        private System.Threading.SendOrPostCallback WebserviceverificarPersonalOperationCompleted;
        
        private System.Threading.SendOrPostCallback WebserviceguardarPersonalOperationCompleted;
        
        private System.Threading.SendOrPostCallback WebserviceverificarHistorialOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ProcesoWSDL() {
            this.Url = global::Panchita.Properties.Settings.Default.Registro_Personal_Panchita_ProcesoWSDL_ProcesoWSDL;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event WebserviceobtenerPedidosCompletedEventHandler WebserviceobtenerPedidosCompleted;
        
        /// <remarks/>
        public event WebserviceguardarPedidosCompletedEventHandler WebserviceguardarPedidosCompleted;
        
        /// <remarks/>
        public event WebserviceverificarPersonalCompletedEventHandler WebserviceverificarPersonalCompleted;
        
        /// <remarks/>
        public event WebserviceguardarPersonalCompletedEventHandler WebserviceguardarPersonalCompleted;
        
        /// <remarks/>
        public event WebserviceverificarHistorialCompletedEventHandler WebserviceverificarHistorialCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ProcesoWSDL#obtenerPedidos", RequestNamespace="urn:ProcesoWSDL", ResponseNamespace="urn:ProcesoWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string WebserviceobtenerPedidos(string session) {
            object[] results = this.Invoke("WebserviceobtenerPedidos", new object[] {
                        session});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WebserviceobtenerPedidosAsync(string session) {
            this.WebserviceobtenerPedidosAsync(session, null);
        }
        
        /// <remarks/>
        public void WebserviceobtenerPedidosAsync(string session, object userState) {
            if ((this.WebserviceobtenerPedidosOperationCompleted == null)) {
                this.WebserviceobtenerPedidosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWebserviceobtenerPedidosOperationCompleted);
            }
            this.InvokeAsync("WebserviceobtenerPedidos", new object[] {
                        session}, this.WebserviceobtenerPedidosOperationCompleted, userState);
        }
        
        private void OnWebserviceobtenerPedidosOperationCompleted(object arg) {
            if ((this.WebserviceobtenerPedidosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WebserviceobtenerPedidosCompleted(this, new WebserviceobtenerPedidosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ProcesoWSDL#guardarPedidos", RequestNamespace="urn:ProcesoWSDL", ResponseNamespace="urn:ProcesoWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public bool WebserviceguardarPedidos(string session, string pedidos) {
            object[] results = this.Invoke("WebserviceguardarPedidos", new object[] {
                        session,
                        pedidos});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void WebserviceguardarPedidosAsync(string session, string pedidos) {
            this.WebserviceguardarPedidosAsync(session, pedidos, null);
        }
        
        /// <remarks/>
        public void WebserviceguardarPedidosAsync(string session, string pedidos, object userState) {
            if ((this.WebserviceguardarPedidosOperationCompleted == null)) {
                this.WebserviceguardarPedidosOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWebserviceguardarPedidosOperationCompleted);
            }
            this.InvokeAsync("WebserviceguardarPedidos", new object[] {
                        session,
                        pedidos}, this.WebserviceguardarPedidosOperationCompleted, userState);
        }
        
        private void OnWebserviceguardarPedidosOperationCompleted(object arg) {
            if ((this.WebserviceguardarPedidosCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WebserviceguardarPedidosCompleted(this, new WebserviceguardarPedidosCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ProcesoWSDL#verificarPersonal", RequestNamespace="urn:ProcesoWSDL", ResponseNamespace="urn:ProcesoWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string WebserviceverificarPersonal(string lista) {
            object[] results = this.Invoke("WebserviceverificarPersonal", new object[] {
                        lista});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WebserviceverificarPersonalAsync(string lista) {
            this.WebserviceverificarPersonalAsync(lista, null);
        }
        
        /// <remarks/>
        public void WebserviceverificarPersonalAsync(string lista, object userState) {
            if ((this.WebserviceverificarPersonalOperationCompleted == null)) {
                this.WebserviceverificarPersonalOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWebserviceverificarPersonalOperationCompleted);
            }
            this.InvokeAsync("WebserviceverificarPersonal", new object[] {
                        lista}, this.WebserviceverificarPersonalOperationCompleted, userState);
        }
        
        private void OnWebserviceverificarPersonalOperationCompleted(object arg) {
            if ((this.WebserviceverificarPersonalCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WebserviceverificarPersonalCompleted(this, new WebserviceverificarPersonalCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ProcesoWSDL#guardarPersonal", RequestNamespace="urn:ProcesoWSDL", ResponseNamespace="urn:ProcesoWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public bool WebserviceguardarPersonal(string lista) {
            object[] results = this.Invoke("WebserviceguardarPersonal", new object[] {
                        lista});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void WebserviceguardarPersonalAsync(string lista) {
            this.WebserviceguardarPersonalAsync(lista, null);
        }
        
        /// <remarks/>
        public void WebserviceguardarPersonalAsync(string lista, object userState) {
            if ((this.WebserviceguardarPersonalOperationCompleted == null)) {
                this.WebserviceguardarPersonalOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWebserviceguardarPersonalOperationCompleted);
            }
            this.InvokeAsync("WebserviceguardarPersonal", new object[] {
                        lista}, this.WebserviceguardarPersonalOperationCompleted, userState);
        }
        
        private void OnWebserviceguardarPersonalOperationCompleted(object arg) {
            if ((this.WebserviceguardarPersonalCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WebserviceguardarPersonalCompleted(this, new WebserviceguardarPersonalCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:ProcesoWSDL#verificarHistorial", RequestNamespace="urn:ProcesoWSDL", ResponseNamespace="urn:ProcesoWSDL")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string WebserviceverificarHistorial(string lista, int sucursal) {
            object[] results = this.Invoke("WebserviceverificarHistorial", new object[] {
                        lista,
                        sucursal});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WebserviceverificarHistorialAsync(string lista, int sucursal) {
            this.WebserviceverificarHistorialAsync(lista, sucursal, null);
        }
        
        /// <remarks/>
        public void WebserviceverificarHistorialAsync(string lista, int sucursal, object userState) {
            if ((this.WebserviceverificarHistorialOperationCompleted == null)) {
                this.WebserviceverificarHistorialOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWebserviceverificarHistorialOperationCompleted);
            }
            this.InvokeAsync("WebserviceverificarHistorial", new object[] {
                        lista,
                        sucursal}, this.WebserviceverificarHistorialOperationCompleted, userState);
        }
        
        private void OnWebserviceverificarHistorialOperationCompleted(object arg) {
            if ((this.WebserviceverificarHistorialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WebserviceverificarHistorialCompleted(this, new WebserviceverificarHistorialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void WebserviceobtenerPedidosCompletedEventHandler(object sender, WebserviceobtenerPedidosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebserviceobtenerPedidosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WebserviceobtenerPedidosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void WebserviceguardarPedidosCompletedEventHandler(object sender, WebserviceguardarPedidosCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebserviceguardarPedidosCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WebserviceguardarPedidosCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void WebserviceverificarPersonalCompletedEventHandler(object sender, WebserviceverificarPersonalCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebserviceverificarPersonalCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WebserviceverificarPersonalCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void WebserviceguardarPersonalCompletedEventHandler(object sender, WebserviceguardarPersonalCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebserviceguardarPersonalCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WebserviceguardarPersonalCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    public delegate void WebserviceverificarHistorialCompletedEventHandler(object sender, WebserviceverificarHistorialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WebserviceverificarHistorialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WebserviceverificarHistorialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591