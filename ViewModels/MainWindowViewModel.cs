using ReactiveUI;
using System;
using System.Reactive;

namespace AvaloniaApplication1.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        private int _selectedTabIndex = 0;
        private string _statusMessage = "Готов к работе";

        public string StatusMessage
        {
            get => _statusMessage;
            set => this.RaiseAndSetIfChanged(ref _statusMessage, value);
        }

        public int SelectedTabIndex
        {
            get => _selectedTabIndex;
            set => this.RaiseAndSetIfChanged(ref _selectedTabIndex, value);
        }

        public ReactiveCommand<Unit, Unit> NewProjectCommand { get; }
        public ReactiveCommand<Unit, Unit> LoadProjectCommand { get; }
        public ReactiveCommand<Unit, Unit> SaveProjectCommand { get; }
        public ReactiveCommand<Unit, Unit> ExitCommand { get; }
        public ReactiveCommand<Unit, Unit> CalculateCommand { get; }
        public ReactiveCommand<Unit, Unit> StopCalculationCommand { get; }
        public ReactiveCommand<Unit, Unit> AboutCommand { get; }

        public MainWindowViewModel()
        {
            NewProjectCommand = ReactiveCommand.Create(() => { StatusMessage = "Создан новый проект"; });
            LoadProjectCommand = ReactiveCommand.Create(() => { StatusMessage = "Загрузка проекта.."; });
            SaveProjectCommand = ReactiveCommand.Create(() => { StatusMessage = "Сохранение проекта.."; });
            ExitCommand = ReactiveCommand.Create(() => { Environment.Exit(0); });
            CalculateCommand = ReactiveCommand.Create(() => { StatusMessage = "Выполняется расчет.."; });
            StopCalculationCommand = ReactiveCommand.Create(() => { StatusMessage = "Расчет остановлен"; });
            AboutCommand = ReactiveCommand.Create(() => { StatusMessage = "О программе"; });
        }
    }
}
