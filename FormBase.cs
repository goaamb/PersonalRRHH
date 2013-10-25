﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace Panchita
{
    public class FormBase : System.Windows.Forms.Form
    {
        public NotifyIcon notifyIcon;
        protected IContainer components;
        public ContextMenu contextMenu;
        public MenuItem mi1;
        public MenuItem mi2;
        public MenuItem mi3;


        public FormBase():this(false) {
            ;
        }

        public FormBase(Boolean notify) {
            crearMenu();
            if(notify) CreateNotifyicon();
        }

        public void notifyIcon_DoubleClick(object Sender, EventArgs e)
        {
            Visible = !Visible;
            if (Visible) mi1.Text = "&Ocultar";
            else mi1.Text = "&Mostrar";
        }
        public void registrarPersona_Click(object Sender, EventArgs e){
            if (GetType() == typeof(RegistroPersonal))
            {
                if (!Visible) notifyIcon_DoubleClick(Sender, e);
                Focus();
            }
            else {
                RegistroPersonal r = new RegistroPersonal();
                r.Show();
                r.Focus();
            }
        }

        public  void crearMenu()
        {
            contextMenu = new ContextMenu();
            mi1 = new MenuItem("&Ocultar", notifyIcon_DoubleClick);
            contextMenu.MenuItems.Add(mi1);
            mi2 = new MenuItem("&Registrar Personal", registrarPersona_Click);
            contextMenu.MenuItems.Add(mi2);
            mi3 = new MenuItem("&Salir", Salir_Click);
            contextMenu.MenuItems.Add(mi3);
        }

        private  void Salir_Click(object Sender, EventArgs e)
        {
            GC.Collect();
            formMain f = formMain.getInstance();
            f.notifyIcon.Visible = false;
            f.Dispose();
            f.Close();
            Application.Exit();
        }

        public  void CreateNotifyicon()
        {
            notifyIcon = new System.Windows.Forms.NotifyIcon(new System.ComponentModel.Container());
            notifyIcon.ContextMenu = contextMenu;
            notifyIcon.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            notifyIcon.Text = Text;
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += new System.EventHandler(notifyIcon_DoubleClick);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.SuspendLayout();
            // 
            // FormBase
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBase_FormClosed);
            this.ResumeLayout(false);

        }

        protected void FormBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown)
            {
                Salir_Click(sender, e);
            }else if(notifyIcon!=null)notifyIcon.Visible = false;
        }
    }
}