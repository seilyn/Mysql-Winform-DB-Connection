
namespace StarDB {
    partial class Form1 {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.GridStarcraft = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textATK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDEF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridStarcraft)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(555, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Database Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridStarcraft
            // 
            this.GridStarcraft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStarcraft.Location = new System.Drawing.Point(264, 12);
            this.GridStarcraft.Name = "GridStarcraft";
            this.GridStarcraft.RowHeadersWidth = 51;
            this.GridStarcraft.RowTemplate.Height = 27;
            this.GridStarcraft.Size = new System.Drawing.Size(555, 307);
            this.GridStarcraft.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textDEF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textATK);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textRace);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 387);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Starcraft";
            // 
            // textRace
            // 
            this.textRace.Location = new System.Drawing.Point(6, 56);
            this.textRace.Name = "textRace";
            this.textRace.Size = new System.Drawing.Size(221, 25);
            this.textRace.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13F);
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit Race";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(6, 126);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(221, 25);
            this.textName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13F);
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unit Name";
            // 
            // textATK
            // 
            this.textATK.Location = new System.Drawing.Point(6, 199);
            this.textATK.Name = "textATK";
            this.textATK.Size = new System.Drawing.Size(221, 25);
            this.textATK.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13F);
            this.label3.Location = new System.Drawing.Point(6, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unit ATK";
            // 
            // textDEF
            // 
            this.textDEF.Location = new System.Drawing.Point(6, 273);
            this.textDEF.Name = "textDEF";
            this.textDEF.Size = new System.Drawing.Size(221, 25);
            this.textDEF.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13F);
            this.label4.Location = new System.Drawing.Point(6, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Unit DEF";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 316);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(220, 31);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add Unit(A)";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete Unit(D)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GridStarcraft);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Starcraft";
            ((System.ComponentModel.ISupportInitialize)(this.GridStarcraft)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridStarcraft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textATK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDEF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button2;
    }
}

