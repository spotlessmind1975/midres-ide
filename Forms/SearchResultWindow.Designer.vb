<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchResultWindow
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchResultWindow))
        Me.ListBoxSearchResult = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBoxSearchResult
        '
        Me.ListBoxSearchResult.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxSearchResult.FormattingEnabled = True
        Me.ListBoxSearchResult.ItemHeight = 16
        Me.ListBoxSearchResult.Location = New System.Drawing.Point(15, 19)
        Me.ListBoxSearchResult.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListBoxSearchResult.Name = "ListBoxSearchResult"
        Me.ListBoxSearchResult.Size = New System.Drawing.Size(983, 628)
        Me.ListBoxSearchResult.TabIndex = 0
        '
        'SearchResultWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 571)
        Me.Controls.Add(Me.ListBoxSearchResult)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SearchResultWindow"
        Me.Text = "Search results (in files)"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxSearchResult As ListBox
End Class
