<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Button2 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Библиотека2DataSet = New БазаД.Библиотека2DataSet
        Me.ИздательстваBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ИздательстваTableAdapter = New БазаД.Библиотека2DataSetTableAdapters.ИздательстваTableAdapter
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.НазваниеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Библиотека2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ИздательстваBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(243, 529)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Книги"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.НазваниеDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ИздательстваBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(522, 511)
        Me.DataGridView1.TabIndex = 8
        '
        'Библиотека2DataSet
        '
        Me.Библиотека2DataSet.DataSetName = "Библиотека2DataSet"
        Me.Библиотека2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ИздательстваBindingSource
        '
        Me.ИздательстваBindingSource.DataMember = "Издательства"
        Me.ИздательстваBindingSource.DataSource = Me.Библиотека2DataSet
        '
        'ИздательстваTableAdapter
        '
        Me.ИздательстваTableAdapter.ClearBeforeFill = True
        '
        'КодDataGridViewTextBoxColumn
        '
        Me.КодDataGridViewTextBoxColumn.DataPropertyName = "Код"
        Me.КодDataGridViewTextBoxColumn.HeaderText = "Код"
        Me.КодDataGridViewTextBoxColumn.Name = "КодDataGridViewTextBoxColumn"
        '
        'НазваниеDataGridViewTextBoxColumn
        '
        Me.НазваниеDataGridViewTextBoxColumn.DataPropertyName = "Название"
        Me.НазваниеDataGridViewTextBoxColumn.HeaderText = "Название"
        Me.НазваниеDataGridViewTextBoxColumn.Name = "НазваниеDataGridViewTextBoxColumn"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 564)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Издательсвта"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Библиотека2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ИздательстваBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Библиотека2DataSet As БазаД.Библиотека2DataSet
    Friend WithEvents ИздательстваBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ИздательстваTableAdapter As БазаД.Библиотека2DataSetTableAdapters.ИздательстваTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НазваниеDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
