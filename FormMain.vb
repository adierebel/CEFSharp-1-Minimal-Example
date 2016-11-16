Imports CefSharp
Imports CefSharp.WinForms
Public Class FormMain
    Dim WebView As CefSharp.WinForms.WebView
    Public Sub New()
        InitializeComponent()
        Dim WebViewSetting As New CefSharp.BrowserSettings
        WebView = New WebView(String.Empty, WebViewSetting)
        WebView.Dock = DockStyle.Fill
        PanelBrowser.Controls.Add(WebView)
        PanelBrowser.Width = Me.Width
        PanelBrowser.Height = Me.Height - 40
        PanelBrowser.Top = 40
        PanelBrowser.Left = 0
        WebView.RegisterJsObject("regJS", New regJS())
    End Sub
    Private Sub FormMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        PanelBrowser.Width = Me.Width
        PanelBrowser.Height = Me.Height
    End Sub
    Private Sub FormMain_ResizeEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ResizeEnd
        PanelBrowser.Width = Me.Width
        PanelBrowser.Height = Me.Height
    End Sub
    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub ButtonHTML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHTML.Click
        WebView.LoadHtml("<html><body style='margin:0;padding:0;'><br /><br /><h1><center>Hi, HTML Loaded !</center></h1><script type='text/javascript'>regJS.helloJS('halo dunia !');</script ></body></html>", "about:blank")
    End Sub
    Private Sub TimerLoad_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerLoad.Tick
        If WebView.IsBrowserInitialized = True Then
            WebView.LoadHtml("<html><body><h1>Test</h1></body></html>", "about:blank")
            TimerLoad.Enabled = False
        End If
    End Sub

    Private Sub ButtonURL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonURL.Click
        WebView.Load(TextBoxURL.Text)
    End Sub
End Class
Public Class regJS
    Public Sub helloJS(ByVal text As String)
        MsgBox("hit from JS -> " & text)
    End Sub
End Class