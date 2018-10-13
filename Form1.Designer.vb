<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cards
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CardsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ISP_program1DataSet = New WindowsApplication1.ISP_program1DataSet()
        Me.CardsTableAdapter = New WindowsApplication1.ISP_program1DataSetTableAdapters.cardsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ISP_program1DataSetTableAdapters.TableAdapterManager()
        Me.Delete = New System.Windows.Forms.Button()
        Me.bck = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.slct = New System.Windows.Forms.Button()
        Me.TowersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TowersTableAdapter = New WindowsApplication1.ISP_program1DataSetTableAdapters.towersTableAdapter()
        Me.CardsnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartokedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpiredDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ext = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ISP_program1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TowersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CardsnoDataGridViewTextBoxColumn, Me.CardsIDDataGridViewTextBoxColumn, Me.PartokedateDataGridViewTextBoxColumn, Me.ExpiredDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CardsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(25, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 271)
        Me.DataGridView1.TabIndex = 0
        '
        'CardsBindingSource
        '
        Me.CardsBindingSource.DataMember = "cards"
        Me.CardsBindingSource.DataSource = Me.ISP_program1DataSet
        '
        'ISP_program1DataSet
        '
        Me.ISP_program1DataSet.DataSetName = "ISP_program1DataSet"
        Me.ISP_program1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CardsTableAdapter
        '
        Me.CardsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cardsTableAdapter = Me.CardsTableAdapter
        Me.TableAdapterManager.signUpTableAdapter = Nothing
        Me.TableAdapterManager.towersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ISP_program1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Delete.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Delete.ForeColor = System.Drawing.Color.SlateGray
        Me.Delete.Location = New System.Drawing.Point(399, 67)
        Me.Delete.Margin = New System.Windows.Forms.Padding(7)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(101, 50)
        Me.Delete.TabIndex = 42
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'bck
        '
        Me.bck.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.bck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bck.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.bck.ForeColor = System.Drawing.Color.SlateGray
        Me.bck.Location = New System.Drawing.Point(399, 132)
        Me.bck.Margin = New System.Windows.Forms.Padding(7)
        Me.bck.Name = "bck"
        Me.bck.Size = New System.Drawing.Size(101, 50)
        Me.bck.TabIndex = 41
        Me.bck.Text = "Back"
        Me.bck.UseVisualStyleBackColor = False
        '
        'Add
        '
        Me.Add.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Add.ForeColor = System.Drawing.Color.SlateGray
        Me.Add.Location = New System.Drawing.Point(276, 67)
        Me.Add.Margin = New System.Windows.Forms.Padding(7)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(105, 50)
        Me.Add.TabIndex = 40
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = False
        '
        'slct
        '
        Me.slct.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.slct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.slct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.slct.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.slct.ForeColor = System.Drawing.Color.SlateGray
        Me.slct.Location = New System.Drawing.Point(276, 132)
        Me.slct.Margin = New System.Windows.Forms.Padding(7)
        Me.slct.Name = "slct"
        Me.slct.Size = New System.Drawing.Size(105, 50)
        Me.slct.TabIndex = 39
        Me.slct.Text = "Select"
        Me.slct.UseVisualStyleBackColor = False
        '
        'TowersBindingSource
        '
        Me.TowersBindingSource.DataMember = "towers"
        Me.TowersBindingSource.DataSource = Me.ISP_program1DataSet
        '
        'TowersTableAdapter
        '
        Me.TowersTableAdapter.ClearBeforeFill = True
        '
        'CardsnoDataGridViewTextBoxColumn
        '
        Me.CardsnoDataGridViewTextBoxColumn.DataPropertyName = "cards-no"
        Me.CardsnoDataGridViewTextBoxColumn.HeaderText = "cards-no"
        Me.CardsnoDataGridViewTextBoxColumn.Name = "CardsnoDataGridViewTextBoxColumn"
        '
        'CardsIDDataGridViewTextBoxColumn
        '
        Me.CardsIDDataGridViewTextBoxColumn.DataPropertyName = "cards-ID"
        Me.CardsIDDataGridViewTextBoxColumn.HeaderText = "cards-ID"
        Me.CardsIDDataGridViewTextBoxColumn.Name = "CardsIDDataGridViewTextBoxColumn"
        '
        'PartokedateDataGridViewTextBoxColumn
        '
        Me.PartokedateDataGridViewTextBoxColumn.DataPropertyName = "partoke-date"
        Me.PartokedateDataGridViewTextBoxColumn.HeaderText = "partoke-date"
        Me.PartokedateDataGridViewTextBoxColumn.Name = "PartokedateDataGridViewTextBoxColumn"
        '
        'ExpiredDataGridViewTextBoxColumn
        '
        Me.ExpiredDataGridViewTextBoxColumn.DataPropertyName = "expired"
        Me.ExpiredDataGridViewTextBoxColumn.HeaderText = "expired"
        Me.ExpiredDataGridViewTextBoxColumn.Name = "ExpiredDataGridViewTextBoxColumn"
        '
        'ext
        '
        Me.ext.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ext.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.ext.ForeColor = System.Drawing.Color.SlateGray
        Me.ext.Location = New System.Drawing.Point(336, 196)
        Me.ext.Margin = New System.Windows.Forms.Padding(7)
        Me.ext.Name = "ext"
        Me.ext.Size = New System.Drawing.Size(101, 50)
        Me.ext.TabIndex = 43
        Me.ext.Text = "Exit"
        Me.ext.UseVisualStyleBackColor = False
        '
        'cards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(530, 360)
        Me.Controls.Add(Me.ext)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.bck)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.slct)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "cards"
        Me.Text = "Cards"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ISP_program1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TowersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ISP_program1DataSet As WindowsApplication1.ISP_program1DataSet
    Friend WithEvents CardsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CardsTableAdapter As WindowsApplication1.ISP_program1DataSetTableAdapters.cardsTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.ISP_program1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents bck As System.Windows.Forms.Button
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents slct As System.Windows.Forms.Button
    Friend WithEvents TowersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TowersTableAdapter As WindowsApplication1.ISP_program1DataSetTableAdapters.towersTableAdapter
    Friend WithEvents CardsnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CardsIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartokedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpiredDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ext As System.Windows.Forms.Button

End Class
