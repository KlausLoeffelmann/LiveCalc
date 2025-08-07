using Microsoft.Extensions.DependencyInjection;
using WarpToolkit.ComponentModel;

namespace CalcWinForms;

partial class MainForm : IServiceProvider
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private readonly IUserSettingsService _userSettingsService = null;
    private readonly IServiceProvider _serviceProvider = null;

    /// <summary>
    ///  Initializes a new instance of the <see cref="MainForm"/> class with dependency injection support.
    /// </summary>
    /// <param name="serviceProvider">
    ///  The service provider that contains all registered services for dependency injection.
    ///  This parameter is used to resolve dependencies and configure the form with the required services.
    /// </param>
    /// <exception cref="ArgumentNullException">
    ///  Thrown when <paramref name="serviceProvider"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="NullReferenceException">
    ///  Thrown when the required <see cref="IUserSettingsService"/> is not registered in the service provider.
    /// </exception>
    /// <remarks>
    ///  This constructor overload is specifically designed to be used when the Form is instantiated 
    ///  through Dependency Injection (DI) using the <c>WinFormsApplication</c> class and the 
    ///  <c>WinFormsApplicationBuilder</c>. This approach provides the same infrastructure pattern 
    ///  as ASP.NET Core applications, enabling familiar service registration, configuration, 
    ///  and dependency injection patterns in WinForms applications.
    ///  <para>
    ///   When using this constructor, the Form acts as a ServiceProvider-aware component, 
    ///   allowing it to resolve and utilize services that have been registered in the 
    ///   application's service container. This enables loose coupling, testability, 
    ///   and modern application architecture patterns in WinForms development.
    ///  </para>
    ///  <para>
    ///   The constructor automatically assigns the service provider to the form using the 
    ///   <c>AssignServiceProvider</c> extension method and resolves the required 
    ///   <see cref="IUserSettingsService"/> from the container.
    ///  </para>
    /// </remarks>
    public MainForm(IServiceProvider serviceProvider)
    {
        ArgumentNullException.ThrowIfNull(serviceProvider, nameof(serviceProvider));
        _serviceProvider = serviceProvider;
        _userSettingsService = serviceProvider.GetRequiredService<IUserSettingsService>();

        if (_userSettingsService is null)
        {
            throw new NullReferenceException($"The service '{nameof(IUserSettingsService)}' is not registered.");
        }

        InitializeComponent();
    }

    object IServiceProvider.GetService(Type serviceType)
    {
        ArgumentNullException.ThrowIfNull(serviceType, nameof(serviceType));

        if (_serviceProvider is null)
        {
            throw new InvalidOperationException("Service provider is not initialized.");
        }

        return _serviceProvider.GetService(serviceType)
            ?? throw new InvalidOperationException($"Service of type '{serviceType.Name}' is not registered.");
    }

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        _pnlDisplay = new Panel();
        _lblExpression = new Label();
        calculatorViewModelBindingSource = new BindingSource(components);
        _lblResult = new Label();
        _tlpButtons = new TableLayoutPanel();
        _btnMC = new Button();
        _btnMR = new Button();
        _btnMPlus = new Button();
        _btnMMinus = new Button();
        _btnPercent = new Button();
        _btnCE = new Button();
        _btnC = new Button();
        _btnBack = new Button();
        _btnOneOverX = new Button();
        _btnXSquared = new Button();
        _btnSqrt = new Button();
        _btnDivide = new Button();
        _btn7 = new Button();
        _btn8 = new Button();
        _btn9 = new Button();
        _btnMultiply = new Button();
        _btn4 = new Button();
        _btn5 = new Button();
        _btn6 = new Button();
        _btnMinus = new Button();
        _btn1 = new Button();
        _btn2 = new Button();
        _btn3 = new Button();
        _btnPlus = new Button();
        _btnPlusMinus = new Button();
        _btn0 = new Button();
        _btnDecimal = new Button();
        _btnEquals = new Button();
        _pnlDisplay.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)calculatorViewModelBindingSource).BeginInit();
        _tlpButtons.SuspendLayout();
        SuspendLayout();
        // 
        // _pnlDisplay
        // 
        _pnlDisplay.BackColor = Color.Black;
        _pnlDisplay.BorderStyle = BorderStyle.FixedSingle;
        _pnlDisplay.Controls.Add(_lblExpression);
        _pnlDisplay.Controls.Add(_lblResult);
        _pnlDisplay.Dock = DockStyle.Top;
        _pnlDisplay.Location = new Point(8, 8);
        _pnlDisplay.Name = "_pnlDisplay";
        _pnlDisplay.Padding = new Padding(10);
        _pnlDisplay.Size = new Size(496, 98);
        _pnlDisplay.TabIndex = 0;
        // 
        // _lblExpression
        // 
        _lblExpression.AutoSize = true;
        _lblExpression.DataBindings.Add(new Binding("Text", calculatorViewModelBindingSource, "Formula", true));
        _lblExpression.Dock = DockStyle.Top;
        _lblExpression.Font = new Font("Segoe UI", 12F);
        _lblExpression.ForeColor = Color.Gray;
        _lblExpression.Location = new Point(10, 10);
        _lblExpression.Name = "_lblExpression";
        _lblExpression.Size = new Size(68, 45);
        _lblExpression.TabIndex = 1;
        _lblExpression.Text = "6 ×";
        _lblExpression.TextAlign = ContentAlignment.TopRight;
        // 
        // calculatorViewModelBindingSource
        // 
        calculatorViewModelBindingSource.DataSource = typeof(CalcCore.CalculatorViewModel);
        // 
        // _lblResult
        // 
        _lblResult.DataBindings.Add(new Binding("Text", calculatorViewModelBindingSource, "DisplayValue.Display", true));
        _lblResult.Dock = DockStyle.Fill;
        _lblResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        _lblResult.ForeColor = Color.White;
        _lblResult.Location = new Point(10, 10);
        _lblResult.Name = "_lblResult";
        _lblResult.Size = new Size(474, 76);
        _lblResult.TabIndex = 0;
        _lblResult.Text = "42";
        _lblResult.TextAlign = ContentAlignment.MiddleRight;
        // 
        // _tlpButtons
        // 
        _tlpButtons.ColumnCount = 4;
        _tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        _tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        _tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        _tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        _tlpButtons.Controls.Add(_btnMC, 0, 0);
        _tlpButtons.Controls.Add(_btnMR, 1, 0);
        _tlpButtons.Controls.Add(_btnMPlus, 2, 0);
        _tlpButtons.Controls.Add(_btnMMinus, 3, 0);
        _tlpButtons.Controls.Add(_btnPercent, 0, 1);
        _tlpButtons.Controls.Add(_btnCE, 1, 1);
        _tlpButtons.Controls.Add(_btnC, 2, 1);
        _tlpButtons.Controls.Add(_btnBack, 3, 1);
        _tlpButtons.Controls.Add(_btnOneOverX, 0, 2);
        _tlpButtons.Controls.Add(_btnXSquared, 1, 2);
        _tlpButtons.Controls.Add(_btnSqrt, 2, 2);
        _tlpButtons.Controls.Add(_btnDivide, 3, 2);
        _tlpButtons.Controls.Add(_btn7, 0, 3);
        _tlpButtons.Controls.Add(_btn8, 1, 3);
        _tlpButtons.Controls.Add(_btn9, 2, 3);
        _tlpButtons.Controls.Add(_btnMultiply, 3, 3);
        _tlpButtons.Controls.Add(_btn4, 0, 4);
        _tlpButtons.Controls.Add(_btn5, 1, 4);
        _tlpButtons.Controls.Add(_btn6, 2, 4);
        _tlpButtons.Controls.Add(_btnMinus, 3, 4);
        _tlpButtons.Controls.Add(_btn1, 0, 5);
        _tlpButtons.Controls.Add(_btn2, 1, 5);
        _tlpButtons.Controls.Add(_btn3, 2, 5);
        _tlpButtons.Controls.Add(_btnPlus, 3, 5);
        _tlpButtons.Controls.Add(_btnPlusMinus, 0, 6);
        _tlpButtons.Controls.Add(_btn0, 1, 6);
        _tlpButtons.Controls.Add(_btnDecimal, 2, 6);
        _tlpButtons.Controls.Add(_btnEquals, 3, 6);
        _tlpButtons.Dock = DockStyle.Fill;
        _tlpButtons.Location = new Point(8, 106);
        _tlpButtons.Name = "_tlpButtons";
        _tlpButtons.RowCount = 7;
        _tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
        _tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
        _tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
        _tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
        _tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
        _tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
        _tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
        _tlpButtons.Size = new Size(496, 584);
        _tlpButtons.TabIndex = 1;
        // 
        // _btnMC
        // 
        _btnMC.BackColor = Color.FromArgb(50, 50, 80);
        _btnMC.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnMC.Dock = DockStyle.Fill;
        _btnMC.FlatAppearance.BorderSize = 0;
        _btnMC.FlatStyle = FlatStyle.Flat;
        _btnMC.Font = new Font("Segoe UI", 12F);
        _btnMC.ForeColor = Color.White;
        _btnMC.Location = new Point(3, 3);
        _btnMC.Name = "_btnMC";
        _btnMC.Size = new Size(118, 77);
        _btnMC.TabIndex = 0;
        _btnMC.Text = "MC";
        _btnMC.UseVisualStyleBackColor = false;
        // 
        // _btnMR
        // 
        _btnMR.BackColor = Color.FromArgb(50, 50, 80);
        _btnMR.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnMR.Dock = DockStyle.Fill;
        _btnMR.FlatAppearance.BorderSize = 0;
        _btnMR.FlatStyle = FlatStyle.Flat;
        _btnMR.Font = new Font("Segoe UI", 12F);
        _btnMR.ForeColor = Color.White;
        _btnMR.Location = new Point(127, 3);
        _btnMR.Name = "_btnMR";
        _btnMR.Size = new Size(118, 77);
        _btnMR.TabIndex = 1;
        _btnMR.Text = "MR";
        _btnMR.UseVisualStyleBackColor = false;
        // 
        // _btnMPlus
        // 
        _btnMPlus.BackColor = Color.FromArgb(50, 50, 80);
        _btnMPlus.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnMPlus.Dock = DockStyle.Fill;
        _btnMPlus.FlatAppearance.BorderSize = 0;
        _btnMPlus.FlatStyle = FlatStyle.Flat;
        _btnMPlus.Font = new Font("Segoe UI", 12F);
        _btnMPlus.ForeColor = Color.White;
        _btnMPlus.Location = new Point(251, 3);
        _btnMPlus.Name = "_btnMPlus";
        _btnMPlus.Size = new Size(118, 77);
        _btnMPlus.TabIndex = 2;
        _btnMPlus.Text = "M+";
        _btnMPlus.UseVisualStyleBackColor = false;
        // 
        // _btnMMinus
        // 
        _btnMMinus.BackColor = Color.FromArgb(50, 50, 80);
        _btnMMinus.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnMMinus.Dock = DockStyle.Fill;
        _btnMMinus.FlatAppearance.BorderSize = 0;
        _btnMMinus.FlatStyle = FlatStyle.Flat;
        _btnMMinus.Font = new Font("Segoe UI", 12F);
        _btnMMinus.ForeColor = Color.White;
        _btnMMinus.Location = new Point(375, 3);
        _btnMMinus.Name = "_btnMMinus";
        _btnMMinus.Size = new Size(118, 77);
        _btnMMinus.TabIndex = 3;
        _btnMMinus.Text = "M-";
        _btnMMinus.UseVisualStyleBackColor = false;
        // 
        // _btnPercent
        // 
        _btnPercent.BackColor = Color.FromArgb(50, 50, 80);
        _btnPercent.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnPercent.Dock = DockStyle.Fill;
        _btnPercent.FlatAppearance.BorderSize = 0;
        _btnPercent.FlatStyle = FlatStyle.Flat;
        _btnPercent.Font = new Font("Segoe UI", 12F);
        _btnPercent.ForeColor = Color.White;
        _btnPercent.Location = new Point(3, 86);
        _btnPercent.Name = "_btnPercent";
        _btnPercent.Size = new Size(118, 77);
        _btnPercent.TabIndex = 4;
        _btnPercent.Text = "%";
        _btnPercent.UseVisualStyleBackColor = false;
        // 
        // _btnCE
        // 
        _btnCE.BackColor = Color.FromArgb(50, 50, 80);
        _btnCE.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnCE.Dock = DockStyle.Fill;
        _btnCE.FlatAppearance.BorderSize = 0;
        _btnCE.FlatStyle = FlatStyle.Flat;
        _btnCE.Font = new Font("Segoe UI", 12F);
        _btnCE.ForeColor = Color.White;
        _btnCE.Location = new Point(127, 86);
        _btnCE.Name = "_btnCE";
        _btnCE.Size = new Size(118, 77);
        _btnCE.TabIndex = 5;
        _btnCE.Text = "CE";
        _btnCE.UseVisualStyleBackColor = false;
        // 
        // _btnC
        // 
        _btnC.BackColor = Color.FromArgb(50, 50, 80);
        _btnC.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnC.Dock = DockStyle.Fill;
        _btnC.FlatAppearance.BorderSize = 0;
        _btnC.FlatStyle = FlatStyle.Flat;
        _btnC.Font = new Font("Segoe UI", 12F);
        _btnC.ForeColor = Color.White;
        _btnC.Location = new Point(251, 86);
        _btnC.Name = "_btnC";
        _btnC.Size = new Size(118, 77);
        _btnC.TabIndex = 6;
        _btnC.Text = "C";
        _btnC.UseVisualStyleBackColor = false;
        // 
        // _btnBack
        // 
        _btnBack.BackColor = Color.FromArgb(50, 50, 80);
        _btnBack.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnBack.Dock = DockStyle.Fill;
        _btnBack.FlatAppearance.BorderSize = 0;
        _btnBack.FlatStyle = FlatStyle.Flat;
        _btnBack.Font = new Font("Segoe UI", 12F);
        _btnBack.ForeColor = Color.White;
        _btnBack.Location = new Point(375, 86);
        _btnBack.Name = "_btnBack";
        _btnBack.Size = new Size(118, 77);
        _btnBack.TabIndex = 7;
        _btnBack.Text = "Back";
        _btnBack.UseVisualStyleBackColor = false;
        // 
        // _btnOneOverX
        // 
        _btnOneOverX.BackColor = Color.FromArgb(50, 50, 80);
        _btnOneOverX.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnOneOverX.Dock = DockStyle.Fill;
        _btnOneOverX.FlatAppearance.BorderSize = 0;
        _btnOneOverX.FlatStyle = FlatStyle.Flat;
        _btnOneOverX.Font = new Font("Segoe UI", 12F);
        _btnOneOverX.ForeColor = Color.White;
        _btnOneOverX.Location = new Point(3, 169);
        _btnOneOverX.Name = "_btnOneOverX";
        _btnOneOverX.Size = new Size(118, 77);
        _btnOneOverX.TabIndex = 8;
        _btnOneOverX.Text = "1/x";
        _btnOneOverX.UseVisualStyleBackColor = false;
        // 
        // _btnXSquared
        // 
        _btnXSquared.BackColor = Color.FromArgb(50, 50, 80);
        _btnXSquared.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnXSquared.Dock = DockStyle.Fill;
        _btnXSquared.FlatAppearance.BorderSize = 0;
        _btnXSquared.FlatStyle = FlatStyle.Flat;
        _btnXSquared.Font = new Font("Segoe UI", 12F);
        _btnXSquared.ForeColor = Color.White;
        _btnXSquared.Location = new Point(127, 169);
        _btnXSquared.Name = "_btnXSquared";
        _btnXSquared.Size = new Size(118, 77);
        _btnXSquared.TabIndex = 9;
        _btnXSquared.Text = "x²";
        _btnXSquared.UseVisualStyleBackColor = false;
        // 
        // _btnSqrt
        // 
        _btnSqrt.BackColor = Color.FromArgb(50, 50, 80);
        _btnSqrt.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnSqrt.Dock = DockStyle.Fill;
        _btnSqrt.FlatAppearance.BorderSize = 0;
        _btnSqrt.FlatStyle = FlatStyle.Flat;
        _btnSqrt.Font = new Font("Segoe UI", 12F);
        _btnSqrt.ForeColor = Color.White;
        _btnSqrt.Location = new Point(251, 169);
        _btnSqrt.Name = "_btnSqrt";
        _btnSqrt.Size = new Size(118, 77);
        _btnSqrt.TabIndex = 10;
        _btnSqrt.Text = "sqrt";
        _btnSqrt.UseVisualStyleBackColor = false;
        // 
        // _btnDivide
        // 
        _btnDivide.BackColor = Color.FromArgb(50, 50, 80);
        _btnDivide.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnDivide.Dock = DockStyle.Fill;
        _btnDivide.FlatAppearance.BorderSize = 0;
        _btnDivide.FlatStyle = FlatStyle.Flat;
        _btnDivide.Font = new Font("Segoe UI", 12F);
        _btnDivide.ForeColor = Color.White;
        _btnDivide.Location = new Point(375, 169);
        _btnDivide.Name = "_btnDivide";
        _btnDivide.Size = new Size(118, 77);
        _btnDivide.TabIndex = 11;
        _btnDivide.Text = "/";
        _btnDivide.UseVisualStyleBackColor = false;
        // 
        // _btn7
        // 
        _btn7.BackColor = Color.FromArgb(50, 50, 80);
        _btn7.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btn7.Dock = DockStyle.Fill;
        _btn7.FlatAppearance.BorderSize = 0;
        _btn7.FlatStyle = FlatStyle.Flat;
        _btn7.Font = new Font("Segoe UI", 12F);
        _btn7.ForeColor = Color.White;
        _btn7.Location = new Point(3, 252);
        _btn7.Name = "_btn7";
        _btn7.Size = new Size(118, 77);
        _btn7.TabIndex = 12;
        _btn7.Text = "7";
        _btn7.UseVisualStyleBackColor = false;
        // 
        // _btn8
        // 
        _btn8.BackColor = Color.FromArgb(50, 50, 80);
        _btn8.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btn8.Dock = DockStyle.Fill;
        _btn8.FlatAppearance.BorderSize = 0;
        _btn8.FlatStyle = FlatStyle.Flat;
        _btn8.Font = new Font("Segoe UI", 12F);
        _btn8.ForeColor = Color.White;
        _btn8.Location = new Point(127, 252);
        _btn8.Name = "_btn8";
        _btn8.Size = new Size(118, 77);
        _btn8.TabIndex = 13;
        _btn8.Text = "8";
        _btn8.UseVisualStyleBackColor = false;
        // 
        // _btn9
        // 
        _btn9.BackColor = Color.FromArgb(50, 50, 80);
        _btn9.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btn9.Dock = DockStyle.Fill;
        _btn9.FlatAppearance.BorderSize = 0;
        _btn9.FlatStyle = FlatStyle.Flat;
        _btn9.Font = new Font("Segoe UI", 12F);
        _btn9.ForeColor = Color.White;
        _btn9.Location = new Point(251, 252);
        _btn9.Name = "_btn9";
        _btn9.Size = new Size(118, 77);
        _btn9.TabIndex = 14;
        _btn9.Text = "9";
        _btn9.UseVisualStyleBackColor = false;
        // 
        // _btnMultiply
        // 
        _btnMultiply.BackColor = Color.FromArgb(50, 50, 80);
        _btnMultiply.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnMultiply.Dock = DockStyle.Fill;
        _btnMultiply.FlatAppearance.BorderSize = 0;
        _btnMultiply.FlatStyle = FlatStyle.Flat;
        _btnMultiply.Font = new Font("Segoe UI", 12F);
        _btnMultiply.ForeColor = Color.White;
        _btnMultiply.Location = new Point(375, 252);
        _btnMultiply.Name = "_btnMultiply";
        _btnMultiply.Size = new Size(118, 77);
        _btnMultiply.TabIndex = 15;
        _btnMultiply.Text = "*";
        _btnMultiply.UseVisualStyleBackColor = false;
        // 
        // _btn4
        // 
        _btn4.BackColor = Color.FromArgb(50, 50, 80);
        _btn4.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btn4.Dock = DockStyle.Fill;
        _btn4.FlatAppearance.BorderSize = 0;
        _btn4.FlatStyle = FlatStyle.Flat;
        _btn4.Font = new Font("Segoe UI", 12F);
        _btn4.ForeColor = Color.White;
        _btn4.Location = new Point(3, 335);
        _btn4.Name = "_btn4";
        _btn4.Size = new Size(118, 77);
        _btn4.TabIndex = 16;
        _btn4.Text = "4";
        _btn4.UseVisualStyleBackColor = false;
        // 
        // _btn5
        // 
        _btn5.BackColor = Color.FromArgb(50, 50, 80);
        _btn5.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btn5.Dock = DockStyle.Fill;
        _btn5.FlatAppearance.BorderSize = 0;
        _btn5.FlatStyle = FlatStyle.Flat;
        _btn5.Font = new Font("Segoe UI", 12F);
        _btn5.ForeColor = Color.White;
        _btn5.Location = new Point(127, 335);
        _btn5.Name = "_btn5";
        _btn5.Size = new Size(118, 77);
        _btn5.TabIndex = 17;
        _btn5.Text = "5";
        _btn5.UseVisualStyleBackColor = false;
        // 
        // _btn6
        // 
        _btn6.BackColor = Color.FromArgb(50, 50, 80);
        _btn6.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btn6.Dock = DockStyle.Fill;
        _btn6.FlatAppearance.BorderSize = 0;
        _btn6.FlatStyle = FlatStyle.Flat;
        _btn6.Font = new Font("Segoe UI", 12F);
        _btn6.ForeColor = Color.White;
        _btn6.Location = new Point(251, 335);
        _btn6.Name = "_btn6";
        _btn6.Size = new Size(118, 77);
        _btn6.TabIndex = 18;
        _btn6.Text = "6";
        _btn6.UseVisualStyleBackColor = false;
        // 
        // _btnMinus
        // 
        _btnMinus.BackColor = Color.FromArgb(50, 50, 80);
        _btnMinus.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnMinus.Dock = DockStyle.Fill;
        _btnMinus.FlatAppearance.BorderSize = 0;
        _btnMinus.FlatStyle = FlatStyle.Flat;
        _btnMinus.Font = new Font("Segoe UI", 12F);
        _btnMinus.ForeColor = Color.White;
        _btnMinus.Location = new Point(375, 335);
        _btnMinus.Name = "_btnMinus";
        _btnMinus.Size = new Size(118, 77);
        _btnMinus.TabIndex = 19;
        _btnMinus.Text = "-";
        _btnMinus.UseVisualStyleBackColor = false;
        // 
        // _btn1
        // 
        _btn1.BackColor = Color.FromArgb(50, 50, 80);
        _btn1.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btn1.Dock = DockStyle.Fill;
        _btn1.FlatAppearance.BorderSize = 0;
        _btn1.FlatStyle = FlatStyle.Flat;
        _btn1.Font = new Font("Segoe UI", 12F);
        _btn1.ForeColor = Color.White;
        _btn1.Location = new Point(3, 418);
        _btn1.Name = "_btn1";
        _btn1.Size = new Size(118, 77);
        _btn1.TabIndex = 20;
        _btn1.Text = "1";
        _btn1.UseVisualStyleBackColor = false;
        // 
        // _btn2
        // 
        _btn2.BackColor = Color.FromArgb(50, 50, 80);
        _btn2.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btn2.Dock = DockStyle.Fill;
        _btn2.FlatAppearance.BorderSize = 0;
        _btn2.FlatStyle = FlatStyle.Flat;
        _btn2.Font = new Font("Segoe UI", 12F);
        _btn2.ForeColor = Color.White;
        _btn2.Location = new Point(127, 418);
        _btn2.Name = "_btn2";
        _btn2.Size = new Size(118, 77);
        _btn2.TabIndex = 21;
        _btn2.Text = "2";
        _btn2.UseVisualStyleBackColor = false;
        // 
        // _btn3
        // 
        _btn3.BackColor = Color.FromArgb(50, 50, 80);
        _btn3.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btn3.Dock = DockStyle.Fill;
        _btn3.FlatAppearance.BorderSize = 0;
        _btn3.FlatStyle = FlatStyle.Flat;
        _btn3.Font = new Font("Segoe UI", 12F);
        _btn3.ForeColor = Color.White;
        _btn3.Location = new Point(251, 418);
        _btn3.Name = "_btn3";
        _btn3.Size = new Size(118, 77);
        _btn3.TabIndex = 22;
        _btn3.Text = "3";
        _btn3.UseVisualStyleBackColor = false;
        // 
        // _btnPlus
        // 
        _btnPlus.BackColor = Color.FromArgb(50, 50, 80);
        _btnPlus.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnPlus.Dock = DockStyle.Fill;
        _btnPlus.FlatAppearance.BorderSize = 0;
        _btnPlus.FlatStyle = FlatStyle.Flat;
        _btnPlus.Font = new Font("Segoe UI", 12F);
        _btnPlus.ForeColor = Color.White;
        _btnPlus.Location = new Point(375, 418);
        _btnPlus.Name = "_btnPlus";
        _btnPlus.Size = new Size(118, 77);
        _btnPlus.TabIndex = 23;
        _btnPlus.Text = "+";
        _btnPlus.UseVisualStyleBackColor = false;
        // 
        // _btnPlusMinus
        // 
        _btnPlusMinus.BackColor = Color.FromArgb(50, 50, 80);
        _btnPlusMinus.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnPlusMinus.Dock = DockStyle.Fill;
        _btnPlusMinus.FlatAppearance.BorderSize = 0;
        _btnPlusMinus.FlatStyle = FlatStyle.Flat;
        _btnPlusMinus.Font = new Font("Segoe UI", 12F);
        _btnPlusMinus.ForeColor = Color.White;
        _btnPlusMinus.Location = new Point(3, 501);
        _btnPlusMinus.Name = "_btnPlusMinus";
        _btnPlusMinus.Size = new Size(118, 80);
        _btnPlusMinus.TabIndex = 24;
        _btnPlusMinus.Text = "+/-";
        _btnPlusMinus.UseVisualStyleBackColor = false;
        // 
        // _btn0
        // 
        _btn0.BackColor = Color.FromArgb(50, 50, 80);
        _btn0.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btn0.Dock = DockStyle.Fill;
        _btn0.FlatAppearance.BorderSize = 0;
        _btn0.FlatStyle = FlatStyle.Flat;
        _btn0.Font = new Font("Segoe UI", 12F);
        _btn0.ForeColor = Color.White;
        _btn0.Location = new Point(127, 501);
        _btn0.Name = "_btn0";
        _btn0.Size = new Size(118, 80);
        _btn0.TabIndex = 25;
        _btn0.Text = "0";
        _btn0.UseVisualStyleBackColor = false;
        // 
        // _btnDecimal
        // 
        _btnDecimal.BackColor = Color.FromArgb(50, 50, 80);
        _btnDecimal.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnDecimal.Dock = DockStyle.Fill;
        _btnDecimal.FlatAppearance.BorderSize = 0;
        _btnDecimal.FlatStyle = FlatStyle.Flat;
        _btnDecimal.Font = new Font("Segoe UI", 12F);
        _btnDecimal.ForeColor = Color.White;
        _btnDecimal.Location = new Point(251, 501);
        _btnDecimal.Name = "_btnDecimal";
        _btnDecimal.Size = new Size(118, 80);
        _btnDecimal.TabIndex = 26;
        _btnDecimal.Text = ".";
        _btnDecimal.UseVisualStyleBackColor = false;
        // 
        // _btnEquals
        // 
        _btnEquals.BackColor = Color.FromArgb(100, 200, 255);
        _btnEquals.DataBindings.Add(new Binding("Command", calculatorViewModelBindingSource, "ExecuteCommand", true));
        _btnEquals.Dock = DockStyle.Fill;
        _btnEquals.FlatAppearance.BorderSize = 0;
        _btnEquals.FlatStyle = FlatStyle.Flat;
        _btnEquals.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        _btnEquals.ForeColor = Color.Black;
        _btnEquals.Location = new Point(375, 501);
        _btnEquals.Name = "_btnEquals";
        _btnEquals.Size = new Size(118, 80);
        _btnEquals.TabIndex = 27;
        _btnEquals.Text = "=";
        _btnEquals.UseVisualStyleBackColor = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(13F, 32F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(30, 30, 30);
        ClientSize = new Size(512, 698);
        Controls.Add(_tlpButtons);
        Controls.Add(_pnlDisplay);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        Padding = new Padding(8);
        Text = "Calculator";
        _pnlDisplay.ResumeLayout(false);
        _pnlDisplay.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)calculatorViewModelBindingSource).EndInit();
        _tlpButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel _pnlDisplay;
    private Label _lblExpression;
    private Label _lblResult;
    private TableLayoutPanel _tlpButtons;
    private Button _btnMC;
    private Button _btnMR;
    private Button _btnMPlus;
    private Button _btnMMinus;
    private Button _btnPercent;
    private Button _btnCE;
    private Button _btnC;
    private Button _btnBack;
    private Button _btnOneOverX;
    private Button _btnXSquared;
    private Button _btnSqrt;
    private Button _btnDivide;
    private Button _btn7;
    private Button _btn8;
    private Button _btn9;
    private Button _btnMultiply;
    private Button _btn4;
    private Button _btn5;
    private Button _btn6;
    private Button _btnMinus;
    private Button _btn1;
    private Button _btn2;
    private Button _btn3;
    private Button _btnPlus;
    private Button _btnPlusMinus;
    private Button _btn0;
    private Button _btnDecimal;
    private Button _btnEquals;
    private BindingSource calculatorViewModelBindingSource;
}
