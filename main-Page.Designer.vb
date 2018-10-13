<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainpage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.towersInfo = New System.Windows.Forms.Button()
        Me.slct = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OwnersnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OwnersnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ISP_program1DataSet = New WindowsApplication1.ISP_program1DataSet()
        Me.Add = New System.Windows.Forms.Button()
        Me.upate = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UsersTableAdapter = New WindowsApplication1.ISP_program1DataSetTableAdapters.usersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ISP_program1DataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISP_program1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(36, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "OwnerNum"
        '
        'towersInfo
        '
        Me.towersInfo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.towersInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.towersInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.towersInfo.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.towersInfo.ForeColor = System.Drawing.Color.SlateGray
        Me.towersInfo.Location = New System.Drawing.Point(413, 286)
        Me.towersInfo.Margin = New System.Windows.Forms.Padding(7)
        Me.towersInfo.Name = "towersInfo"
        Me.towersInfo.Size = New System.Drawing.Size(115, 51)
        Me.towersInfo.TabIndex = 7
        Me.towersInfo.Text = "Towers-Info"
        Me.towersInfo.UseVisualStyleBackColor = False
        '
        'slct
        '
        Me.slct.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.slct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.slct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.slct.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.slct.ForeColor = System.Drawing.Color.SlateGray
        Me.slct.Location = New System.Drawing.Point(290, 182)
        Me.slct.Margin = New System.Windows.Forms.Padding(7)
        Me.slct.Name = "slct"
        Me.slct.Size = New System.Drawing.Size(119, 51)
        Me.slct.TabIndex = 8
        Me.slct.Text = "Select"
        Me.slct.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "OwnerName"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OwnersnoDataGridViewTextBoxColumn, Me.OwnersnameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UsersBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(25, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(228, 276)
        Me.DataGridView1.TabIndex = 34
        '
        'OwnersnoDataGridViewTextBoxColumn
        '
        Me.OwnersnoDataGridViewTextBoxColumn.DataPropertyName = "owners-no"
        Me.OwnersnoDataGridViewTextBoxColumn.HeaderText = "owners-no"
        Me.OwnersnoDataGridViewTextBoxColumn.Name = "OwnersnoDataGridViewTextBoxColumn"
        '
        'OwnersnameDataGridViewTextBoxColumn
        '
        Me.OwnersnameDataGridViewTextBoxColumn.DataPropertyName = "owners-name"
        Me.OwnersnameDataGridViewTextBoxColumn.HeaderText = "owners-name"
        Me.OwnersnameDataGridViewTextBoxColumn.Name = "OwnersnameDataGridViewTextBoxColumn"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.ISP_program1DataSet
        '
        'ISP_program1DataSet
        '
        Me.ISP_program1DataSet.DataSetName = "ISP_program1DataSet"
        Me.ISP_program1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Add.ForeColor = System.Drawing.Color.SlateGray
        Me.Add.Location = New System.Drawing.Point(290, 117)
        Me.Add.Margin = New System.Windows.Forms.Padding(7)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(119, 51)
        Me.Add.TabIndex = 35
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = False
        '
        'upate
        '
        Me.upate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.upate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.upate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.upate.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.upate.ForeColor = System.Drawing.Color.SlateGray
        Me.upate.Location = New System.Drawing.Point(413, 117)
        Me.upate.Margin = New System.Windows.Forms.Padding(7)
        Me.upate.Name = "upate"
        Me.upate.Size = New System.Drawing.Size(115, 51)
        Me.upate.TabIndex = 37
        Me.upate.Text = "Update"
        Me.upate.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Delete.ForeColor = System.Drawing.Color.SlateGray
        Me.Delete.Location = New System.Drawing.Point(413, 182)
        Me.Delete.Margin = New System.Windows.Forms.Padding(7)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(115, 51)
        Me.Delete.TabIndex = 38
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button1.ForeColor = System.Drawing.Color.SlateGray
        Me.Button1.Location = New System.Drawing.Point(290, 286)
        Me.Button1.Margin = New System.Windows.Forms.Padding(7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 51)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Cards-Info"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button2.ForeColor = System.Drawing.Color.SlateGray
        Me.Button2.Location = New System.Drawing.Point(358, 351)
        Me.Button2.Margin = New System.Windows.Forms.Padding(7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 51)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cardsTableAdapter = Nothing
        Me.TableAdapterManager.signUpTableAdapter = Nothing
        Me.TableAdapterManager.towersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ISP_program1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Me.UsersTableAdapter
        '
        'mainpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(671, 477)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.upate)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.slct)
        Me.Controls.Add(Me.towersInfo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.LightGray
        Me.Name = "mainpage"
        Me.Text = "Main Page"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISP_program1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents towersInfo As System.Windows.Forms.Button
    Friend WithEvents slct As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents upate As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ISP_program1DataSet As WindowsApplication1.ISP_program1DataSet
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As WindowsApplication1.ISP_program1DataSetTableAdapters.usersTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.ISP_program1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents OwnersnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OwnersnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
