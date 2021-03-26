<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Библиотека2DataSet = New БазаД.Библиотека2DataSet
        Me.КнигиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.КнигиTableAdapter = New БазаД.Библиотека2DataSetTableAdapters.КнигиTableAdapter
        Me.КодDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.НазваниеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ГодИздDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КодИздDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ЦенаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.КоличествоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Библиотека2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КнигиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(177, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Авторы"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.КодDataGridViewTextBoxColumn, Me.НазваниеDataGridViewTextBoxColumn, Me.ГодИздDataGridViewTextBoxColumn, Me.КодИздDataGridViewTextBoxColumn, Me.ЦенаDataGridViewTextBoxColumn, Me.КоличествоDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.КнигиBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(762, 247)
        Me.DataGridView1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(395, 300)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "КнгАвт"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(286, 300)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 37)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Издательства"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(504, 300)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 37)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Запросы"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Библиотека2DataSet
        '
        Me.Библиотека2DataSet.DataSetName = "Библиотека2DataSet"
        Me.Библиотека2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'КнигиBindingSource
        '
        Me.КнигиBindingSource.DataMember = "Книги"
        Me.КнигиBindingSource.DataSource = Me.Библиотека2DataSet
        '
        'КнигиTableAdapter
        '
        Me.КнигиTableAdapter.ClearBeforeFill = True
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
        'ГодИздDataGridViewTextBoxColumn
        '
        Me.ГодИздDataGridViewTextBoxColumn.DataPropertyName = "ГодИзд"
        Me.ГодИздDataGridViewTextBoxColumn.HeaderText = "ГодИзд"
        Me.ГодИздDataGridViewTextBoxColumn.Name = "ГодИздDataGridViewTextBoxColumn"
        '
        'КодИздDataGridViewTextBoxColumn
        '
        Me.КодИздDataGridViewTextBoxColumn.DataPropertyName = "КодИзд"
        Me.КодИздDataGridViewTextBoxColumn.HeaderText = "КодИзд"
        Me.КодИздDataGridViewTextBoxColumn.Name = "КодИздDataGridViewTextBoxColumn"
        '
        'ЦенаDataGridViewTextBoxColumn
        '
        Me.ЦенаDataGridViewTextBoxColumn.DataPropertyName = "Цена"
        Me.ЦенаDataGridViewTextBoxColumn.HeaderText = "Цена"
        Me.ЦенаDataGridViewTextBoxColumn.Name = "ЦенаDataGridViewTextBoxColumn"
        '
        'КоличествоDataGridViewTextBoxColumn
        '
        Me.КоличествоDataGridViewTextBoxColumn.DataPropertyName = "Количество"
        Me.КоличествоDataGridViewTextBoxColumn.HeaderText = "Количество"
        Me.КоличествоDataGridViewTextBoxColumn.Name = "КоличествоDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 349)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Книги"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Библиотека2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КнигиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Библиотека2DataSet As БазаД.Библиотека2DataSet
    Friend WithEvents КнигиBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents КнигиTableAdapter As БазаД.Библиотека2DataSetTableAdapters.КнигиTableAdapter
    Friend WithEvents КодDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents НазваниеDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ГодИздDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КодИздDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ЦенаDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents КоличествоDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
