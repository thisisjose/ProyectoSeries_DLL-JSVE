﻿namespace ProyectoSeries_DLL_JSVE.Forms
{
    partial class FormColas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNroCapitulos = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrdenarCola = new System.Windows.Forms.Button();
            this.btnEditarCola = new System.Windows.Forms.Button();
            this.btnEliminarCola = new System.Windows.Forms.Button();
            this.GridColas = new System.Windows.Forms.DataGridView();
            this.NombreSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCapitulosSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarCola = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridColas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.txtNroCapitulos);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.btnAgregarCola);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 518);
            this.panel1.TabIndex = 2;
            // 
            // txtNroCapitulos
            // 
            this.txtNroCapitulos.Location = new System.Drawing.Point(119, 186);
            this.txtNroCapitulos.Name = "txtNroCapitulos";
            this.txtNroCapitulos.Size = new System.Drawing.Size(100, 22);
            this.txtNroCapitulos.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(109, 139);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(110, 22);
            this.txtDescripcion.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nro. capitulos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 22);
            this.txtNombre.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.GridColas);
            this.panel2.Controls.Add(this.btnOrdenarCola);
            this.panel2.Controls.Add(this.btnEditarCola);
            this.panel2.Controls.Add(this.btnEliminarCola);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 518);
            this.panel2.TabIndex = 3;
            // 
            // btnOrdenarCola
            // 
            this.btnOrdenarCola.BackColor = System.Drawing.Color.Goldenrod;
            this.btnOrdenarCola.FlatAppearance.BorderSize = 0;
            this.btnOrdenarCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarCola.ForeColor = System.Drawing.Color.White;
            this.btnOrdenarCola.Location = new System.Drawing.Point(9, 334);
            this.btnOrdenarCola.Name = "btnOrdenarCola";
            this.btnOrdenarCola.Size = new System.Drawing.Size(195, 35);
            this.btnOrdenarCola.TabIndex = 9;
            this.btnOrdenarCola.Text = "Ordenar";
            this.btnOrdenarCola.UseVisualStyleBackColor = false;
            // 
            // btnEditarCola
            // 
            this.btnEditarCola.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarCola.FlatAppearance.BorderSize = 0;
            this.btnEditarCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCola.ForeColor = System.Drawing.Color.White;
            this.btnEditarCola.Location = new System.Drawing.Point(210, 334);
            this.btnEditarCola.Name = "btnEditarCola";
            this.btnEditarCola.Size = new System.Drawing.Size(195, 35);
            this.btnEditarCola.TabIndex = 7;
            this.btnEditarCola.Text = "Editar";
            this.btnEditarCola.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCola
            // 
            this.btnEliminarCola.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminarCola.FlatAppearance.BorderSize = 0;
            this.btnEliminarCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCola.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCola.Location = new System.Drawing.Point(411, 334);
            this.btnEliminarCola.Name = "btnEliminarCola";
            this.btnEliminarCola.Size = new System.Drawing.Size(195, 35);
            this.btnEliminarCola.TabIndex = 8;
            this.btnEliminarCola.Text = "Eliminar";
            this.btnEliminarCola.UseVisualStyleBackColor = false;
            // 
            // GridColas
            // 
            this.GridColas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridColas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            this.GridColas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridColas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridColas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridColas.ColumnHeadersHeight = 20;
            this.GridColas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridColas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreSerie,
            this.DescripcionSerie,
            this.NroCapitulosSerie});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridColas.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridColas.EnableHeadersVisualStyles = false;
            this.GridColas.GridColor = System.Drawing.Color.SteelBlue;
            this.GridColas.Location = new System.Drawing.Point(9, 94);
            this.GridColas.Name = "GridColas";
            this.GridColas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridColas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridColas.RowHeadersWidth = 51;
            this.GridColas.RowTemplate.Height = 24;
            this.GridColas.Size = new System.Drawing.Size(706, 234);
            this.GridColas.TabIndex = 17;
            // 
            // NombreSerie
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.NombreSerie.DefaultCellStyle = dataGridViewCellStyle2;
            this.NombreSerie.HeaderText = "Nombre";
            this.NombreSerie.MinimumWidth = 6;
            this.NombreSerie.Name = "NombreSerie";
            // 
            // DescripcionSerie
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DescripcionSerie.DefaultCellStyle = dataGridViewCellStyle3;
            this.DescripcionSerie.HeaderText = "Descripcion";
            this.DescripcionSerie.MinimumWidth = 6;
            this.DescripcionSerie.Name = "DescripcionSerie";
            // 
            // NroCapitulosSerie
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.NroCapitulosSerie.DefaultCellStyle = dataGridViewCellStyle4;
            this.NroCapitulosSerie.HeaderText = "Nro.Capitulos";
            this.NroCapitulosSerie.MinimumWidth = 6;
            this.NroCapitulosSerie.Name = "NroCapitulosSerie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Colas";
            // 
            // btnAgregarCola
            // 
            this.btnAgregarCola.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregarCola.FlatAppearance.BorderSize = 0;
            this.btnAgregarCola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCola.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCola.Location = new System.Drawing.Point(24, 223);
            this.btnAgregarCola.Name = "btnAgregarCola";
            this.btnAgregarCola.Size = new System.Drawing.Size(195, 35);
            this.btnAgregarCola.TabIndex = 10;
            this.btnAgregarCola.Text = "Agregar";
            this.btnAgregarCola.UseVisualStyleBackColor = false;
            // 
            // FormColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(41)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(986, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormColas";
            this.Text = "FormColas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridColas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNroCapitulos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOrdenarCola;
        private System.Windows.Forms.Button btnEditarCola;
        private System.Windows.Forms.Button btnEliminarCola;
        private System.Windows.Forms.DataGridView GridColas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCapitulosSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarCola;
    }
}