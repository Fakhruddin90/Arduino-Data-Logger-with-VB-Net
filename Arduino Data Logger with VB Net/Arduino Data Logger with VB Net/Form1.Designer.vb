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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxConnectionInd = New System.Windows.Forms.PictureBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelPOT = New System.Windows.Forms.Label()
        Me.LabelLDR2 = New System.Windows.Forms.Label()
        Me.LabelLDR1 = New System.Windows.Forms.Label()
        Me.Control = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBoxRecordInd = New System.Windows.Forms.PictureBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonStopRecording = New System.Windows.Forms.Button()
        Me.ButtonStartRecording = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ProgressBarProcess = New System.Windows.Forms.ProgressBar()
        Me.ButtonSaveToExcel = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDR1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LDR2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POTENTIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATE_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDataLogRecord = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxConnectionInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Control.SuspendLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBoxConnectionInd)
        Me.GroupBox1.Controls.Add(Me.LabelStatus)
        Me.GroupBox1.Controls.Add(Me.ButtonDisconnect)
        Me.GroupBox1.Controls.Add(Me.ButtonConnect)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBaudRate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPort)
        Me.GroupBox1.Controls.Add(Me.ButtonScanPort)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'PictureBoxConnectionInd
        '
        Me.PictureBoxConnectionInd.Image = Global.Arduino_Data_Logger_with_VB_Net.My.Resources.Resources.Red
        Me.PictureBoxConnectionInd.Location = New System.Drawing.Point(298, 1)
        Me.PictureBoxConnectionInd.Name = "PictureBoxConnectionInd"
        Me.PictureBoxConnectionInd.Size = New System.Drawing.Size(13, 13)
        Me.PictureBoxConnectionInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxConnectionInd.TabIndex = 1
        Me.PictureBoxConnectionInd.TabStop = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(197, 0)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(100, 13)
        Me.LabelStatus.TabIndex = 1
        Me.LabelStatus.Text = "Status : Disconnect"
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.Location = New System.Drawing.Point(163, 66)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(150, 23)
        Me.ButtonDisconnect.TabIndex = 5
        Me.ButtonDisconnect.Text = "Disconnect"
        Me.ButtonDisconnect.UseVisualStyleBackColor = True
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(6, 66)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(147, 23)
        Me.ButtonConnect.TabIndex = 4
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(230, 21)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(83, 21)
        Me.ComboBoxBaudRate.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Baud Rate :"
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(88, 20)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(65, 21)
        Me.ComboBoxPort.TabIndex = 1
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.Location = New System.Drawing.Point(6, 19)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(75, 23)
        Me.ButtonScanPort.TabIndex = 0
        Me.ButtonScanPort.Text = "Scan Port"
        Me.ButtonScanPort.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelPOT)
        Me.GroupBox2.Controls.Add(Me.LabelLDR2)
        Me.GroupBox2.Controls.Add(Me.LabelLDR1)
        Me.GroupBox2.Location = New System.Drawing.Point(337, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(204, 105)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Incoming Data (Real-Time/Second)"
        '
        'LabelPOT
        '
        Me.LabelPOT.AutoSize = True
        Me.LabelPOT.Location = New System.Drawing.Point(7, 76)
        Me.LabelPOT.Name = "LabelPOT"
        Me.LabelPOT.Size = New System.Drawing.Size(52, 13)
        Me.LabelPOT.TabIndex = 0
        Me.LabelPOT.Text = "Waiting..."
        '
        'LabelLDR2
        '
        Me.LabelLDR2.AutoSize = True
        Me.LabelLDR2.Location = New System.Drawing.Point(7, 52)
        Me.LabelLDR2.Name = "LabelLDR2"
        Me.LabelLDR2.Size = New System.Drawing.Size(52, 13)
        Me.LabelLDR2.TabIndex = 0
        Me.LabelLDR2.Text = "Waiting..."
        '
        'LabelLDR1
        '
        Me.LabelLDR1.AutoSize = True
        Me.LabelLDR1.Location = New System.Drawing.Point(7, 27)
        Me.LabelLDR1.Name = "LabelLDR1"
        Me.LabelLDR1.Size = New System.Drawing.Size(52, 13)
        Me.LabelLDR1.TabIndex = 0
        Me.LabelLDR1.Text = "Waiting..."
        '
        'Control
        '
        Me.Control.Controls.Add(Me.Label2)
        Me.Control.Controls.Add(Me.PictureBoxRecordInd)
        Me.Control.Controls.Add(Me.ButtonClear)
        Me.Control.Controls.Add(Me.ButtonStopRecording)
        Me.Control.Controls.Add(Me.ButtonStartRecording)
        Me.Control.Location = New System.Drawing.Point(12, 123)
        Me.Control.Name = "Control"
        Me.Control.Size = New System.Drawing.Size(319, 78)
        Me.Control.TabIndex = 2
        Me.Control.TabStop = False
        Me.Control.Text = "Control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Recording"
        '
        'PictureBoxRecordInd
        '
        Me.PictureBoxRecordInd.Image = Global.Arduino_Data_Logger_with_VB_Net.My.Resources.Resources.Red
        Me.PictureBoxRecordInd.Location = New System.Drawing.Point(298, 0)
        Me.PictureBoxRecordInd.Name = "PictureBoxRecordInd"
        Me.PictureBoxRecordInd.Size = New System.Drawing.Size(13, 13)
        Me.PictureBoxRecordInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxRecordInd.TabIndex = 4
        Me.PictureBoxRecordInd.TabStop = False
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(7, 50)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(306, 23)
        Me.ButtonClear.TabIndex = 1
        Me.ButtonClear.Text = "Clear DataGridView and Graph"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonStopRecording
        '
        Me.ButtonStopRecording.Location = New System.Drawing.Point(163, 19)
        Me.ButtonStopRecording.Name = "ButtonStopRecording"
        Me.ButtonStopRecording.Size = New System.Drawing.Size(150, 23)
        Me.ButtonStopRecording.TabIndex = 0
        Me.ButtonStopRecording.Text = "Stop Recording"
        Me.ButtonStopRecording.UseVisualStyleBackColor = True
        '
        'ButtonStartRecording
        '
        Me.ButtonStartRecording.Location = New System.Drawing.Point(7, 20)
        Me.ButtonStartRecording.Name = "ButtonStartRecording"
        Me.ButtonStartRecording.Size = New System.Drawing.Size(146, 23)
        Me.ButtonStartRecording.TabIndex = 0
        Me.ButtonStartRecording.Text = "Start Recording"
        Me.ButtonStartRecording.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ProgressBarProcess)
        Me.GroupBox3.Controls.Add(Me.ButtonSaveToExcel)
        Me.GroupBox3.Location = New System.Drawing.Point(337, 123)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(204, 78)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Export"
        '
        'ProgressBarProcess
        '
        Me.ProgressBarProcess.Location = New System.Drawing.Point(7, 61)
        Me.ProgressBarProcess.Maximum = 10
        Me.ProgressBarProcess.Name = "ProgressBarProcess"
        Me.ProgressBarProcess.Size = New System.Drawing.Size(191, 11)
        Me.ProgressBarProcess.TabIndex = 4
        Me.ProgressBarProcess.Visible = False
        '
        'ButtonSaveToExcel
        '
        Me.ButtonSaveToExcel.Location = New System.Drawing.Point(7, 19)
        Me.ButtonSaveToExcel.Name = "ButtonSaveToExcel"
        Me.ButtonSaveToExcel.Size = New System.Drawing.Size(191, 53)
        Me.ButtonSaveToExcel.TabIndex = 0
        Me.ButtonSaveToExcel.Text = "Save To MS Excel"
        Me.ButtonSaveToExcel.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 209)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(529, 208)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data Grid View (Real-Time/Second)"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.LDR1, Me.LDR2, Me.POTENTIO, Me.TIME, Me.DATE_})
        Me.DataGridView1.Location = New System.Drawing.Point(7, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(516, 182)
        Me.DataGridView1.TabIndex = 0
        '
        'No
        '
        Me.No.FillWeight = 60.9137!
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        '
        'LDR1
        '
        Me.LDR1.FillWeight = 107.8173!
        Me.LDR1.HeaderText = "LDR1"
        Me.LDR1.Name = "LDR1"
        '
        'LDR2
        '
        Me.LDR2.FillWeight = 107.8173!
        Me.LDR2.HeaderText = "LDR2"
        Me.LDR2.Name = "LDR2"
        '
        'POTENTIO
        '
        Me.POTENTIO.FillWeight = 107.8173!
        Me.POTENTIO.HeaderText = "POTENTIO"
        Me.POTENTIO.Name = "POTENTIO"
        '
        'TIME
        '
        Me.TIME.FillWeight = 107.8173!
        Me.TIME.HeaderText = "TIME"
        Me.TIME.Name = "TIME"
        '
        'DATE_
        '
        Me.DATE_.FillWeight = 107.8173!
        Me.DATE_.HeaderText = "DATE"
        Me.DATE_.Name = "DATE_"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Chart1)
        Me.GroupBox5.Location = New System.Drawing.Point(548, 13)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(535, 404)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Graph (Real-time/Second)"
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(6, 26)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "LDR1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series2.Legend = "Legend1"
        Series2.Name = "LDR2"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Legend = "Legend1"
        Series3.Name = "POTENTIO"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(523, 372)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'TimerSerial
        '
        Me.TimerSerial.Interval = 1000
        '
        'TimerDataLogRecord
        '
        Me.TimerDataLogRecord.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 429)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Control)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Arduino Data Logger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxConnectionInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Control.ResumeLayout(False)
        Me.Control.PerformLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBoxConnectionInd As PictureBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelPOT As Label
    Friend WithEvents LabelLDR2 As Label
    Friend WithEvents LabelLDR1 As Label
    Friend WithEvents Control As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBoxRecordInd As PictureBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonStopRecording As Button
    Friend WithEvents ButtonStartRecording As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ProgressBarProcess As ProgressBar
    Friend WithEvents ButtonSaveToExcel As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents LDR1 As DataGridViewTextBoxColumn
    Friend WithEvents LDR2 As DataGridViewTextBoxColumn
    Friend WithEvents POTENTIO As DataGridViewTextBoxColumn
    Friend WithEvents TIME As DataGridViewTextBoxColumn
    Friend WithEvents DATE_ As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents TimerDataLogRecord As Timer
End Class
