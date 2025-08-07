using CalcCore;
using Microsoft.Extensions.DependencyInjection;

namespace CalcWinForms;

public partial class MainForm : Form
{
    private CalculatorViewModel? _viewModel;

    public MainForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        
        // Get the CalculatorViewModel from DI or create a new instance
        _viewModel = _serviceProvider?.GetService<CalculatorViewModel>() ?? new CalculatorViewModel();
        
        // Assign the ViewModel to the BindingSource
        calculatorViewModelBindingSource.DataSource = _viewModel;
    }
}
