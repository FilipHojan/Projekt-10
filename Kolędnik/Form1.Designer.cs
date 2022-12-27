
namespace Kolędnik
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.dodawanie = new System.Windows.Forms.Button();
            this.Losowosc = new System.Windows.Forms.CheckBox();
            this.listapiosenek = new System.Windows.Forms.ListBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(132, 89);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(99, 79);
            this.play.TabIndex = 0;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.button1_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Transparent;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.Location = new System.Drawing.Point(132, 186);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(99, 82);
            this.stop.TabIndex = 1;
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Transparent;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restart.Image = ((System.Drawing.Image)(resources.GetObject("restart.Image")));
            this.restart.Location = new System.Drawing.Point(132, 287);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(99, 82);
            this.restart.TabIndex = 2;
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // dodawanie
            // 
            this.dodawanie.BackColor = System.Drawing.Color.Transparent;
            this.dodawanie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dodawanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodawanie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dodawanie.Location = new System.Drawing.Point(590, 418);
            this.dodawanie.Name = "dodawanie";
            this.dodawanie.Size = new System.Drawing.Size(119, 53);
            this.dodawanie.TabIndex = 4;
            this.dodawanie.Text = "Dodaj piosenke";
            this.dodawanie.UseVisualStyleBackColor = false;
            this.dodawanie.Click += new System.EventHandler(this.dodawanie_Click);
            // 
            // Losowosc
            // 
            this.Losowosc.BackColor = System.Drawing.Color.Transparent;
            this.Losowosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Losowosc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Losowosc.Location = new System.Drawing.Point(401, 418);
            this.Losowosc.Name = "Losowosc";
            this.Losowosc.Size = new System.Drawing.Size(124, 58);
            this.Losowosc.TabIndex = 5;
            this.Losowosc.Text = "Losowość";
            this.Losowosc.UseVisualStyleBackColor = false;
            // 
            // listapiosenek
            // 
            this.listapiosenek.BackColor = System.Drawing.SystemColors.Info;
            this.listapiosenek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listapiosenek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listapiosenek.ForeColor = System.Drawing.Color.Red;
            this.listapiosenek.FormattingEnabled = true;
            this.listapiosenek.ItemHeight = 16;
            this.listapiosenek.Location = new System.Drawing.Point(440, 89);
            this.listapiosenek.Name = "listapiosenek";
            this.listapiosenek.Size = new System.Drawing.Size(349, 272);
            this.listapiosenek.TabIndex = 6;
            this.listapiosenek.SelectedIndexChanged += new System.EventHandler(this.listapiosenek_SelectedIndexChanged);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(182, 327);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(10, 10);
            this.player.TabIndex = 7;
            this.player.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(830, 508);
            this.Controls.Add(this.player);
            this.Controls.Add(this.listapiosenek);
            this.Controls.Add(this.Losowosc);
            this.Controls.Add(this.dodawanie);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Christmas song";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button dodawanie;
        private System.Windows.Forms.CheckBox Losowosc;
        private System.Windows.Forms.ListBox listapiosenek;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}

