
namespace Cambios
{
    partial class form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Origem = new System.Windows.Forms.ComboBox();
            this.cb_Destino = new System.Windows.Forms.ComboBox();
            this.btn_Converter = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor :";
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(105, 36);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(287, 23);
            this.txt_Valor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moeda de origem :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moeda de destino :";
            // 
            // cb_Origem
            // 
            this.cb_Origem.FormattingEnabled = true;
            this.cb_Origem.Location = new System.Drawing.Point(199, 82);
            this.cb_Origem.Name = "cb_Origem";
            this.cb_Origem.Size = new System.Drawing.Size(193, 23);
            this.cb_Origem.TabIndex = 4;
            // 
            // cb_Destino
            // 
            this.cb_Destino.FormattingEnabled = true;
            this.cb_Destino.Location = new System.Drawing.Point(199, 126);
            this.cb_Destino.Name = "cb_Destino";
            this.cb_Destino.Size = new System.Drawing.Size(193, 23);
            this.cb_Destino.TabIndex = 5;
            // 
            // btn_Converter
            // 
            this.btn_Converter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Converter.Location = new System.Drawing.Point(424, 36);
            this.btn_Converter.Name = "btn_Converter";
            this.btn_Converter.Size = new System.Drawing.Size(93, 56);
            this.btn_Converter.TabIndex = 6;
            this.btn_Converter.Text = "Converter";
            this.btn_Converter.UseVisualStyleBackColor = true;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Resultado.Location = new System.Drawing.Point(155, 188);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(347, 18);
            this.lbl_Resultado.TabIndex = 7;
            this.lbl_Resultado.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Status.Location = new System.Drawing.Point(26, 237);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(50, 20);
            this.lbl_Status.TabIndex = 8;
            this.lbl_Status.Text = "status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(391, 234);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(137, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 272);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.btn_Converter);
            this.Controls.Add(this.cb_Destino);
            this.Controls.Add(this.cb_Origem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Câmbios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Origem;
        private System.Windows.Forms.ComboBox cb_Destino;
        private System.Windows.Forms.Button btn_Converter;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

