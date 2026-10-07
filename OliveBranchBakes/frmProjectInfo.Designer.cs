namespace OliveBranchBakes
{
    partial class frmProjectInfo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProjectInfo));
            lblTitle = new Label();
            lblProjectName = new Label();
            lblProjectNameValue = new Label();
            lblStudent = new Label();
            lblStudentValue = new Label();
            lblPhase = new Label();
            lblPhaseValue = new Label();
            lblClass = new Label();
            lblClassValue = new Label();
            lblDate = new Label();
            lblDateValue = new Label();
            lblDescription = new Label();
            lblDescriptionValue = new Label();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(24, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(209, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Olive Branch Bakes";
            // 
            // lblProjectName
            // 
            lblProjectName.AutoSize = true;
            lblProjectName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblProjectName.Location = new Point(27, 100);
            lblProjectName.Name = "lblProjectName";
            lblProjectName.Size = new Size(95, 17);
            lblProjectName.TabIndex = 2;
            lblProjectName.Text = "Project Name:";
            // 
            // lblProjectNameValue
            // 
            lblProjectNameValue.AutoSize = true;
            lblProjectNameValue.Font = new Font("Segoe UI", 9.75F);
            lblProjectNameValue.Location = new Point(170, 100);
            lblProjectNameValue.Name = "lblProjectNameValue";
            lblProjectNameValue.Size = new Size(237, 17);
            lblProjectNameValue.TabIndex = 3;
            lblProjectNameValue.Text = "Olive Branch Bakes Order Management";
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblStudent.Location = new Point(27, 132);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(71, 17);
            lblStudent.TabIndex = 4;
            lblStudent.Text = "Developer";
            // 
            // lblStudentValue
            // 
            lblStudentValue.AutoSize = true;
            lblStudentValue.Font = new Font("Segoe UI", 9.75F);
            lblStudentValue.Location = new Point(170, 132);
            lblStudentValue.Name = "lblStudentValue";
            lblStudentValue.Size = new Size(122, 17);
            lblStudentValue.TabIndex = 5;
            lblStudentValue.Text = "Diego Yamashitafuji";
            // 
            // lblPhase
            // 
            lblPhase.AutoSize = true;
            lblPhase.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPhase.Location = new Point(27, 164);
            lblPhase.Name = "lblPhase";
            lblPhase.Size = new Size(98, 17);
            lblPhase.TabIndex = 6;
            lblPhase.Text = "Current Phase:";
            // 
            // lblPhaseValue
            // 
            lblPhaseValue.AutoSize = true;
            lblPhaseValue.Font = new Font("Segoe UI", 9.75F);
            lblPhaseValue.Location = new Point(170, 164);
            lblPhaseValue.Name = "lblPhaseValue";
            lblPhaseValue.Size = new Size(53, 17);
            lblPhaseValue.TabIndex = 7;
            lblPhaseValue.Text = "Phase 1";
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblClass.Location = new Point(27, 196);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(43, 17);
            lblClass.TabIndex = 8;
            lblClass.Text = "Class:";
            // 
            // lblClassValue
            // 
            lblClassValue.AutoSize = true;
            lblClassValue.Font = new Font("Segoe UI", 9.75F);
            lblClassValue.Location = new Point(170, 196);
            lblClassValue.Name = "lblClassValue";
            lblClassValue.Size = new Size(186, 17);
            lblClassValue.TabIndex = 9;
            lblClassValue.Text = "Object-Oriented Programming";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDate.Location = new Point(27, 228);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 17);
            lblDate.TabIndex = 10;
            lblDate.Text = "Date:";
            // 
            // lblDateValue
            // 
            lblDateValue.AutoSize = true;
            lblDateValue.Font = new Font("Segoe UI", 9.75F);
            lblDateValue.Location = new Point(170, 228);
            lblDateValue.Name = "lblDateValue";
            lblDateValue.Size = new Size(67, 17);
            lblDateValue.TabIndex = 11;
            lblDateValue.Text = "9/27/2026";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDescription.Location = new Point(27, 260);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(83, 17);
            lblDescription.TabIndex = 12;
            lblDescription.Text = "Description:";
            // 
            // lblDescriptionValue
            // 
            lblDescriptionValue.Font = new Font("Segoe UI", 9.75F);
            lblDescriptionValue.Location = new Point(170, 260);
            lblDescriptionValue.Name = "lblDescriptionValue";
            lblDescriptionValue.Size = new Size(370, 96);
            lblDescriptionValue.TabIndex = 13;
            lblDescriptionValue.Text = resources.GetString("lblDescriptionValue.Text");
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Font = new Font("Segoe UI", 9.75F);
            btnClose.Location = new Point(450, 372);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 32);
            btnClose.TabIndex = 0;
            btnClose.Text = "&Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmProjectInfo
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(564, 424);
            Controls.Add(btnClose);
            Controls.Add(lblDescriptionValue);
            Controls.Add(lblDescription);
            Controls.Add(lblDateValue);
            Controls.Add(lblDate);
            Controls.Add(lblClassValue);
            Controls.Add(lblClass);
            Controls.Add(lblPhaseValue);
            Controls.Add(lblPhase);
            Controls.Add(lblStudentValue);
            Controls.Add(lblStudent);
            Controls.Add(lblProjectNameValue);
            Controls.Add(lblProjectName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmProjectInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Olive Branch Bakes - Project Information";
            Load += frmProjectInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblProjectName;
        private Label lblProjectNameValue;
        private Label lblStudent;
        private Label lblStudentValue;
        private Label lblPhase;
        private Label lblPhaseValue;
        private Label lblClass;
        private Label lblClassValue;
        private Label lblDate;
        private Label lblDateValue;
        private Label lblDescription;
        private Label lblDescriptionValue;
        private Button btnClose;
    }
}
