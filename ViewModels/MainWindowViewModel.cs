using Avalonia.Threading;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel: ViewModelBase
    {
        private string _statusMessage = "Готов к работе";
        private int _selectedTabIndex = 0;

        public string StatusMessage
        {
            get => _statusMessage;
            set => SetField(ref _statusMessage, value);
        }

        public int SelectedTabIndex
        {
            get => _selectedTabIndex;
            set => SetField(ref _selectedTabIndex, value);
        }

        // Команды меню
        public ICommand NewProjectCommand { get; }
        public ICommand LoadProjectCommand { get; }
        public ICommand SaveProjectCommand { get; }
        public ICommand ExitCommand { get; }
        public ICommand CalculateCommand { get; }
        public ICommand StopCalculationCommand { get; }
        public ICommand AboutCommand { get; }

        // Команда навигации
        public ICommand NavigateCommand { get; }

        public MainWindowViewModel()
        {
            // Инициализация команд
            NewProjectCommand = new RelayCommand(NewProject);
            LoadProjectCommand = new RelayCommand(LoadProject);
            SaveProjectCommand = new RelayCommand(SaveProject);
            ExitCommand = new RelayCommand(Exit);
            CalculateCommand = new RelayCommand(Calculate);
            StopCalculationCommand = new RelayCommand(StopCalculation);
            AboutCommand = new RelayCommand(ShowAbout);
        }

        private void NewProject() => StatusMessage = "Создан новый проект";
        private void LoadProject() => StatusMessage = "Загрузка проекта...";
        private void SaveProject() => StatusMessage = "Сохранение проекта...";
        private void Exit() => Environment.Exit(0);
        private void Calculate() => StatusMessage = "Выполняется расчет...";
        private void StopCalculation() => StatusMessage = "Расчет остановлен";
        private void ShowAbout() => StatusMessage = "О программе";

    }
}
