<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnload = New System.Windows.Forms.Button()
        Me.dataRecord = New System.Windows.Forms.DataGridView()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        CType(Me.dataRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnload
        '
        Me.btnload.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnload.Location = New System.Drawing.Point(25, 82)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(97, 41)
        Me.btnload.TabIndex = 0
        Me.btnload.Text = "Load Info"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'dataRecord
        '
        Me.dataRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataRecord.Location = New System.Drawing.Point(161, 47)
        Me.dataRecord.Name = "dataRecord"
        Me.dataRecord.Size = New System.Drawing.Size(477, 310)
        Me.dataRecord.TabIndex = 1
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(25, 171)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(97, 41)
        Me.btninsert.TabIndex = 2
        Me.btninsert.Text = "Insert Info"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(25, 249)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(97, 40)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 378)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.dataRecord)
        Me.Controls.Add(Me.btnload)
        Me.Name = "Form1"
        Me.Text = "Vehicle Management"
        CType(Me.dataRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnload As Button
    Friend WithEvents dataRecord As DataGridView
    Friend WithEvents btninsert As Button
    Friend WithEvents btnclose As Button
End Class
