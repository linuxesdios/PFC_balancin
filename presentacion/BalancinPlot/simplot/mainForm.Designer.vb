<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.baudRateComboBox = New System.Windows.Forms.ComboBox()
        Me.comPortComboBox = New System.Windows.Forms.ComboBox()
        Me.connectDisconnectButton = New System.Windows.Forms.Button()
        Me.plotSetupBtn = New System.Windows.Forms.Button()
        Me.btn_EnviarPID = New System.Windows.Forms.Button()
        Me.Bt_estado = New System.Windows.Forms.Button()
        Me.Bt_Plot = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PID = New System.Windows.Forms.GroupBox()
        Me.RadioBoton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtBox_Kp = New System.Windows.Forms.TextBox()
        Me.TxtBox_Kd = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ki = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBox_Bias1 = New System.Windows.Forms.TextBox()
        Me.TxtBox_Bias2 = New System.Windows.Forms.TextBox()
        Me.Labelsetpoint = New System.Windows.Forms.Label()
        Me.setpoint = New System.Windows.Forms.TextBox()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.RadioComplementario = New System.Windows.Forms.RadioButton()
        Me.RadioKalman = New System.Windows.Forms.RadioButton()
        Me.R_measure = New System.Windows.Forms.Label()
        Me.Q_bias = New System.Windows.Forms.Label()
        Me.Q_angle = New System.Windows.Forms.Label()
        Me.TxtBox_R_measure = New System.Windows.Forms.TextBox()
        Me.TxtBox_Q_bias = New System.Windows.Forms.TextBox()
        Me.TxtBox_Q_angle = New System.Windows.Forms.TextBox()
        Me.TxtBox_filter = New System.Windows.Forms.TextBox()
        Me.TxtBox_comp = New System.Windows.Forms.TextBox()
        Me.TxtBox_Ts = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TerminalWindow = New System.Windows.Forms.RichTextBox()
        Me.picCaptura = New System.Windows.Forms.PictureBox()
        Me.textBox = New System.Windows.Forms.RichTextBox()
        Me.LoadData = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerTickLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel_Version = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SaveDataStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.bt_captura = New System.Windows.Forms.Button()
        Me.nombre = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cap_text = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PID.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.picCaptura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.084243!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.91576!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1081, 639)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.baudRateComboBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.comPortComboBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.connectDisconnectButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.plotSetupBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_EnviarPID)
        Me.FlowLayoutPanel1.Controls.Add(Me.Bt_estado)
        Me.FlowLayoutPanel1.Controls.Add(Me.Bt_Plot)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1075, 31)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'baudRateComboBox
        '
        Me.baudRateComboBox.FormattingEnabled = True
        Me.baudRateComboBox.Items.AddRange(New Object() {"9600", "19200", "38400", "57600", "115200", "128000", "256000"})
        Me.baudRateComboBox.Location = New System.Drawing.Point(3, 3)
        Me.baudRateComboBox.Name = "baudRateComboBox"
        Me.baudRateComboBox.Size = New System.Drawing.Size(92, 21)
        Me.baudRateComboBox.TabIndex = 13
        '
        'comPortComboBox
        '
        Me.comPortComboBox.FormattingEnabled = True
        Me.comPortComboBox.Location = New System.Drawing.Point(101, 3)
        Me.comPortComboBox.Name = "comPortComboBox"
        Me.comPortComboBox.Size = New System.Drawing.Size(99, 21)
        Me.comPortComboBox.Sorted = True
        Me.comPortComboBox.TabIndex = 12
        '
        'connectDisconnectButton
        '
        Me.connectDisconnectButton.Location = New System.Drawing.Point(206, 3)
        Me.connectDisconnectButton.Name = "connectDisconnectButton"
        Me.connectDisconnectButton.Size = New System.Drawing.Size(76, 28)
        Me.connectDisconnectButton.TabIndex = 14
        Me.connectDisconnectButton.Text = "Conectar"
        Me.connectDisconnectButton.UseVisualStyleBackColor = True
        '
        'plotSetupBtn
        '
        Me.plotSetupBtn.Location = New System.Drawing.Point(288, 3)
        Me.plotSetupBtn.Name = "plotSetupBtn"
        Me.plotSetupBtn.Size = New System.Drawing.Size(87, 28)
        Me.plotSetupBtn.TabIndex = 15
        Me.plotSetupBtn.Text = "Configuración"
        Me.plotSetupBtn.UseVisualStyleBackColor = False
        '
        'btn_EnviarPID
        '
        Me.btn_EnviarPID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_EnviarPID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_EnviarPID.Location = New System.Drawing.Point(381, 3)
        Me.btn_EnviarPID.Name = "btn_EnviarPID"
        Me.btn_EnviarPID.Size = New System.Drawing.Size(90, 28)
        Me.btn_EnviarPID.TabIndex = 22
        Me.btn_EnviarPID.Text = "Enviar PID"
        Me.btn_EnviarPID.UseVisualStyleBackColor = False
        '
        'Bt_estado
        '
        Me.Bt_estado.BackColor = System.Drawing.Color.GreenYellow
        Me.Bt_estado.Location = New System.Drawing.Point(477, 3)
        Me.Bt_estado.Name = "Bt_estado"
        Me.Bt_estado.Size = New System.Drawing.Size(133, 28)
        Me.Bt_estado.TabIndex = 67
        Me.Bt_estado.Text = "ENCENDIDO MOTOR"
        Me.Bt_estado.UseVisualStyleBackColor = False
        '
        'Bt_Plot
        '
        Me.Bt_Plot.BackColor = System.Drawing.Color.Azure
        Me.Bt_Plot.Location = New System.Drawing.Point(616, 3)
        Me.Bt_Plot.Name = "Bt_Plot"
        Me.Bt_Plot.Size = New System.Drawing.Size(132, 28)
        Me.Bt_Plot.TabIndex = 72
        Me.Bt_Plot.Text = "GRAFICAR"
        Me.Bt_Plot.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 40)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer1.Panel1.Controls.Add(Me.PID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Labelsetpoint)
        Me.SplitContainer1.Panel1.Controls.Add(Me.setpoint)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioComplementario)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioKalman)
        Me.SplitContainer1.Panel1.Controls.Add(Me.R_measure)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Q_bias)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Q_angle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtBox_R_measure)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtBox_Q_bias)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtBox_Q_angle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtBox_filter)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtBox_comp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtBox_Ts)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Chart1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1075, 575)
        Me.SplitContainer1.SplitterDistance = 477
        Me.SplitContainer1.TabIndex = 0
        '
        'PID
        '
        Me.PID.Controls.Add(Me.RadioBoton1)
        Me.PID.Controls.Add(Me.RadioButton2)
        Me.PID.Controls.Add(Me.Label7)
        Me.PID.Controls.Add(Me.Label6)
        Me.PID.Controls.Add(Me.Label9)
        Me.PID.Controls.Add(Me.TxtBox_Kp)
        Me.PID.Controls.Add(Me.TxtBox_Kd)
        Me.PID.Controls.Add(Me.TxtBox_Ki)
        Me.PID.Controls.Add(Me.Label8)
        Me.PID.Controls.Add(Me.Label5)
        Me.PID.Controls.Add(Me.TxtBox_Bias1)
        Me.PID.Controls.Add(Me.TxtBox_Bias2)
        Me.PID.Location = New System.Drawing.Point(906, 171)
        Me.PID.Name = "PID"
        Me.PID.Size = New System.Drawing.Size(169, 147)
        Me.PID.TabIndex = 72
        Me.PID.TabStop = False
        '
        'RadioBoton1
        '
        Me.RadioBoton1.AutoSize = True
        Me.RadioBoton1.Checked = True
        Me.RadioBoton1.Location = New System.Drawing.Point(9, 19)
        Me.RadioBoton1.Name = "RadioBoton1"
        Me.RadioBoton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioBoton1.TabIndex = 71
        Me.RadioBoton1.TabStop = True
        Me.RadioBoton1.Text = "Cerrado"
        Me.RadioBoton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(92, 18)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton2.TabIndex = 70
        Me.RadioButton2.Text = "Abierto"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Kp"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Ki"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(108, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Kd"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBox_Kp
        '
        Me.TxtBox_Kp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtBox_Kp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBox_Kp.Location = New System.Drawing.Point(15, 54)
        Me.TxtBox_Kp.Name = "TxtBox_Kp"
        Me.TxtBox_Kp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtBox_Kp.Size = New System.Drawing.Size(37, 20)
        Me.TxtBox_Kp.TabIndex = 47
        Me.TxtBox_Kp.Text = "1"
        Me.TxtBox_Kp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox_Kd
        '
        Me.TxtBox_Kd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtBox_Kd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBox_Kd.Location = New System.Drawing.Point(101, 54)
        Me.TxtBox_Kd.Name = "TxtBox_Kd"
        Me.TxtBox_Kd.Size = New System.Drawing.Size(37, 20)
        Me.TxtBox_Kd.TabIndex = 49
        Me.TxtBox_Kd.Text = "1"
        Me.TxtBox_Kd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox_Ki
        '
        Me.TxtBox_Ki.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtBox_Ki.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBox_Ki.Location = New System.Drawing.Point(58, 54)
        Me.TxtBox_Ki.Name = "TxtBox_Ki"
        Me.TxtBox_Ki.Size = New System.Drawing.Size(37, 20)
        Me.TxtBox_Ki.TabIndex = 48
        Me.TxtBox_Ki.Text = "1"
        Me.TxtBox_Ki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(31, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Bias1"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(97, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Bias2"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBox_Bias1
        '
        Me.TxtBox_Bias1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtBox_Bias1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBox_Bias1.Location = New System.Drawing.Point(30, 102)
        Me.TxtBox_Bias1.Name = "TxtBox_Bias1"
        Me.TxtBox_Bias1.Size = New System.Drawing.Size(37, 20)
        Me.TxtBox_Bias1.TabIndex = 50
        Me.TxtBox_Bias1.Text = "1"
        Me.TxtBox_Bias1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox_Bias2
        '
        Me.TxtBox_Bias2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtBox_Bias2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBox_Bias2.Location = New System.Drawing.Point(96, 102)
        Me.TxtBox_Bias2.Name = "TxtBox_Bias2"
        Me.TxtBox_Bias2.Size = New System.Drawing.Size(37, 20)
        Me.TxtBox_Bias2.TabIndex = 51
        Me.TxtBox_Bias2.Text = "1"
        Me.TxtBox_Bias2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Labelsetpoint
        '
        Me.Labelsetpoint.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Labelsetpoint.AutoSize = True
        Me.Labelsetpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelsetpoint.Location = New System.Drawing.Point(948, 74)
        Me.Labelsetpoint.Name = "Labelsetpoint"
        Me.Labelsetpoint.Size = New System.Drawing.Size(110, 29)
        Me.Labelsetpoint.TabIndex = 69
        Me.Labelsetpoint.Text = "Set Point"
        Me.Labelsetpoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'setpoint
        '
        Me.setpoint.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.setpoint.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.setpoint.Location = New System.Drawing.Point(942, 106)
        Me.setpoint.Name = "setpoint"
        Me.setpoint.Size = New System.Drawing.Size(119, 20)
        Me.setpoint.TabIndex = 68
        Me.setpoint.Text = "0"
        Me.setpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(3, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 477)
        Me.Splitter2.TabIndex = 67
        Me.Splitter2.TabStop = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 477)
        Me.Splitter1.TabIndex = 66
        Me.Splitter1.TabStop = False
        '
        'RadioComplementario
        '
        Me.RadioComplementario.AutoSize = True
        Me.RadioComplementario.Location = New System.Drawing.Point(927, 324)
        Me.RadioComplementario.Name = "RadioComplementario"
        Me.RadioComplementario.Size = New System.Drawing.Size(68, 17)
        Me.RadioComplementario.TabIndex = 65
        Me.RadioComplementario.Text = "Complem"
        Me.RadioComplementario.UseVisualStyleBackColor = True
        '
        'RadioKalman
        '
        Me.RadioKalman.AutoSize = True
        Me.RadioKalman.Checked = True
        Me.RadioKalman.Location = New System.Drawing.Point(1010, 324)
        Me.RadioKalman.Name = "RadioKalman"
        Me.RadioKalman.Size = New System.Drawing.Size(60, 17)
        Me.RadioKalman.TabIndex = 64
        Me.RadioKalman.TabStop = True
        Me.RadioKalman.Text = "Kalman"
        Me.RadioKalman.UseVisualStyleBackColor = True
        '
        'R_measure
        '
        Me.R_measure.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.R_measure.AutoSize = True
        Me.R_measure.Location = New System.Drawing.Point(955, 403)
        Me.R_measure.Name = "R_measure"
        Me.R_measure.Size = New System.Drawing.Size(50, 13)
        Me.R_measure.TabIndex = 63
        Me.R_measure.Text = "R Measu"
        Me.R_measure.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Q_bias
        '
        Me.Q_bias.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Q_bias.AutoSize = True
        Me.Q_bias.Location = New System.Drawing.Point(954, 376)
        Me.Q_bias.Name = "Q_bias"
        Me.Q_bias.Size = New System.Drawing.Size(38, 13)
        Me.Q_bias.TabIndex = 62
        Me.Q_bias.Text = "Q Bias"
        Me.Q_bias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Q_angle
        '
        Me.Q_angle.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Q_angle.AutoSize = True
        Me.Q_angle.Location = New System.Drawing.Point(955, 350)
        Me.Q_angle.Name = "Q_angle"
        Me.Q_angle.Size = New System.Drawing.Size(45, 13)
        Me.Q_angle.TabIndex = 61
        Me.Q_angle.Text = "Q Angle"
        Me.Q_angle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBox_R_measure
        '
        Me.TxtBox_R_measure.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtBox_R_measure.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBox_R_measure.Location = New System.Drawing.Point(1010, 400)
        Me.TxtBox_R_measure.Name = "TxtBox_R_measure"
        Me.TxtBox_R_measure.Size = New System.Drawing.Size(51, 20)
        Me.TxtBox_R_measure.TabIndex = 60
        Me.TxtBox_R_measure.Text = "1"
        Me.TxtBox_R_measure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox_Q_bias
        '
        Me.TxtBox_Q_bias.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtBox_Q_bias.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBox_Q_bias.Location = New System.Drawing.Point(1010, 373)
        Me.TxtBox_Q_bias.Name = "TxtBox_Q_bias"
        Me.TxtBox_Q_bias.Size = New System.Drawing.Size(50, 20)
        Me.TxtBox_Q_bias.TabIndex = 59
        Me.TxtBox_Q_bias.Text = "1"
        Me.TxtBox_Q_bias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox_Q_angle
        '
        Me.TxtBox_Q_angle.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtBox_Q_angle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBox_Q_angle.Location = New System.Drawing.Point(1009, 347)
        Me.TxtBox_Q_angle.Name = "TxtBox_Q_angle"
        Me.TxtBox_Q_angle.Size = New System.Drawing.Size(50, 20)
        Me.TxtBox_Q_angle.TabIndex = 58
        Me.TxtBox_Q_angle.Text = "1"
        Me.TxtBox_Q_angle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox_filter
        '
        Me.TxtBox_filter.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtBox_filter.BackColor = System.Drawing.Color.Aqua
        Me.TxtBox_filter.Location = New System.Drawing.Point(1008, 440)
        Me.TxtBox_filter.Name = "TxtBox_filter"
        Me.TxtBox_filter.Size = New System.Drawing.Size(38, 20)
        Me.TxtBox_filter.TabIndex = 54
        Me.TxtBox_filter.Text = "1"
        Me.TxtBox_filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox_comp
        '
        Me.TxtBox_comp.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtBox_comp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtBox_comp.Location = New System.Drawing.Point(1009, 347)
        Me.TxtBox_comp.Name = "TxtBox_comp"
        Me.TxtBox_comp.Size = New System.Drawing.Size(50, 20)
        Me.TxtBox_comp.TabIndex = 53
        Me.TxtBox_comp.Text = "1"
        Me.TxtBox_comp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBox_Ts
        '
        Me.TxtBox_Ts.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TxtBox_Ts.BackColor = System.Drawing.Color.Red
        Me.TxtBox_Ts.Location = New System.Drawing.Point(983, 145)
        Me.TxtBox_Ts.Name = "TxtBox_Ts"
        Me.TxtBox_Ts.Size = New System.Drawing.Size(37, 20)
        Me.TxtBox_Ts.TabIndex = 44
        Me.TxtBox_Ts.Text = "1"
        Me.TxtBox_Ts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(962, 443)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "filtro"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(962, 350)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "comp"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(953, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tiempo Muestreo(ms)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chart1
        '
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisX.MinorTickMark.Enabled = True
        ChartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisY.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.AxisY.MinorTickMark.Enabled = True
        ChartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.BackColor = System.Drawing.Color.Black
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series1.Color = System.Drawing.Color.Yellow
        Series1.Legend = "Legend1"
        Series1.Name = "Channel 1"
        Series1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series1.ShadowOffset = 1
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series2.Color = System.Drawing.Color.LawnGreen
        Series2.Legend = "Legend1"
        Series2.Name = "Channel 2"
        Series2.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series2.ShadowOffset = 1
        Series3.BorderWidth = 2
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series3.Color = System.Drawing.Color.Aqua
        Series3.Legend = "Legend1"
        Series3.Name = "Channel 3"
        Series3.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series3.ShadowOffset = 1
        Series4.BorderWidth = 2
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine
        Series4.Color = System.Drawing.Color.Magenta
        Series4.Legend = "Legend1"
        Series4.Name = "Channel 4"
        Series4.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Series4.ShadowOffset = 1
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(1075, 477)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "1"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.AccessibleDescription = "Vertical Split for Text boxes"
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TerminalWindow)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.picCaptura)
        Me.SplitContainer2.Panel2.Controls.Add(Me.textBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(1075, 94)
        Me.SplitContainer2.SplitterDistance = 735
        Me.SplitContainer2.TabIndex = 0
        '
        'TerminalWindow
        '
        Me.TerminalWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TerminalWindow.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerminalWindow.Location = New System.Drawing.Point(0, 0)
        Me.TerminalWindow.MaxLength = 1000000
        Me.TerminalWindow.Name = "TerminalWindow"
        Me.TerminalWindow.Size = New System.Drawing.Size(735, 94)
        Me.TerminalWindow.TabIndex = 0
        Me.TerminalWindow.Text = ""
        '
        'picCaptura
        '
        Me.picCaptura.Location = New System.Drawing.Point(239, 47)
        Me.picCaptura.Name = "picCaptura"
        Me.picCaptura.Size = New System.Drawing.Size(100, 50)
        Me.picCaptura.TabIndex = 1
        Me.picCaptura.TabStop = False
        Me.picCaptura.Visible = False
        '
        'textBox
        '
        Me.textBox.Location = New System.Drawing.Point(3, 0)
        Me.textBox.MaxLength = 100000
        Me.textBox.Name = "textBox"
        Me.textBox.Size = New System.Drawing.Size(330, 97)
        Me.textBox.TabIndex = 0
        Me.textBox.Text = ""
        '
        'LoadData
        '
        Me.LoadData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadData.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoadData.Location = New System.Drawing.Point(728, 3)
        Me.LoadData.Margin = New System.Windows.Forms.Padding(40, 3, 3, 3)
        Me.LoadData.Name = "LoadData"
        Me.LoadData.Size = New System.Drawing.Size(141, 25)
        Me.LoadData.TabIndex = 17
        Me.LoadData.Text = "Cargar Datos"
        Me.LoadData.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoadData.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.TimerTickLabel, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel_Version, Me.SaveDataStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 660)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1091, 25)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(63, 20)
        Me.ToolStripStatusLabel1.Text = "Timer Tick"
        '
        'TimerTickLabel
        '
        Me.TimerTickLabel.AutoSize = False
        Me.TimerTickLabel.AutoToolTip = True
        Me.TimerTickLabel.Name = "TimerTickLabel"
        Me.TimerTickLabel.Size = New System.Drawing.Size(70, 20)
        Me.TimerTickLabel.ToolTipText = "If the counter is not updating then program has crashed or stuck in loop."
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(100, 20)
        Me.ToolStripStatusLabel2.Text = "Version (1.0)"
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripStatusLabel_Version
        '
        Me.ToolStripStatusLabel_Version.Name = "ToolStripStatusLabel_Version"
        Me.ToolStripStatusLabel_Version.Size = New System.Drawing.Size(0, 20)
        '
        'SaveDataStatus
        '
        Me.SaveDataStatus.Margin = New System.Windows.Forms.Padding(200, 3, 0, 2)
        Me.SaveDataStatus.Name = "SaveDataStatus"
        Me.SaveDataStatus.Size = New System.Drawing.Size(0, 20)
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM10"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.bt_captura)
        Me.FlowLayoutPanel2.Controls.Add(Me.nombre)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.CheckBox1)
        Me.FlowLayoutPanel2.Controls.Add(Me.cap_text)
        Me.FlowLayoutPanel2.Controls.Add(Me.TextBox2)
        Me.FlowLayoutPanel2.Controls.Add(Me.LoadData)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 621)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1066, 32)
        Me.FlowLayoutPanel2.TabIndex = 73
        '
        'bt_captura
        '
        Me.bt_captura.BackColor = System.Drawing.Color.Yellow
        Me.bt_captura.Location = New System.Drawing.Point(3, 3)
        Me.bt_captura.Name = "bt_captura"
        Me.bt_captura.Size = New System.Drawing.Size(112, 29)
        Me.bt_captura.TabIndex = 75
        Me.bt_captura.Text = "Captura imagen"
        Me.bt_captura.UseVisualStyleBackColor = False
        '
        'nombre
        '
        Me.nombre.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.nombre.AutoSize = True
        Me.nombre.Location = New System.Drawing.Point(121, 11)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(120, 13)
        Me.nombre.TabIndex = 76
        Me.nombre.Text = "Nombre captura imagen"
        Me.nombre.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(247, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(104, 20)
        Me.TextBox1.TabIndex = 74
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckBox1.Location = New System.Drawing.Point(357, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(103, 29)
        Me.CheckBox1.TabIndex = 80
        Me.CheckBox1.Text = "captura de texto"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cap_text
        '
        Me.cap_text.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cap_text.AutoSize = True
        Me.cap_text.Location = New System.Drawing.Point(466, 11)
        Me.cap_text.Name = "cap_text"
        Me.cap_text.Size = New System.Drawing.Size(109, 13)
        Me.cap_text.TabIndex = 79
        Me.cap_text.Text = "Nombre captura texto"
        Me.cap_text.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(581, 7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(104, 20)
        Me.TextBox2.TabIndex = 77
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 685)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BalancinPlot"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PID.ResumeLayout(False)
        Me.PID.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.picCaptura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents textBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimerTickLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents comPortComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents baudRateComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents connectDisconnectButton As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel_Version As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents plotSetupBtn As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TerminalWindow As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SaveDataStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LoadData As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtBox_comp As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Bias2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Ki As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Kp As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Kd As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Bias1 As System.Windows.Forms.TextBox
    Friend WithEvents btn_EnviarPID As System.Windows.Forms.Button
    Friend WithEvents TxtBox_R_measure As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Q_bias As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Q_angle As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_filter As System.Windows.Forms.TextBox
    Friend WithEvents TxtBox_Ts As System.Windows.Forms.TextBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents R_measure As System.Windows.Forms.Label
    Friend WithEvents Q_bias As System.Windows.Forms.Label
    Friend WithEvents Q_angle As System.Windows.Forms.Label
    Friend WithEvents RadioKalman As System.Windows.Forms.RadioButton
    Friend WithEvents RadioComplementario As System.Windows.Forms.RadioButton
    Friend WithEvents Bt_estado As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents picCaptura As System.Windows.Forms.PictureBox
    Friend WithEvents Bt_Plot As System.Windows.Forms.Button
    Friend WithEvents Labelsetpoint As System.Windows.Forms.Label
    Friend WithEvents setpoint As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents bt_captura As System.Windows.Forms.Button
    Friend WithEvents nombre As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents cap_text As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents RadioBoton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PID As System.Windows.Forms.GroupBox

End Class
