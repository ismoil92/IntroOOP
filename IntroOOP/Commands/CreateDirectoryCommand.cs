using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;
    public class CreateDirectoryCommand : FileManagerCommand
    {
        #region FIELDS
        private readonly IUserInterface _userInterface;

        private readonly FileManagerLogic fileManager;
        #endregion

        /// <summary>
        /// Контруктор с двумя параметрами
        /// </summary>
        /// <param name="userInterface">интерфейс пользователя</param>
        /// <param name="fileManager">логика файлового менеджера</param>
        public CreateDirectoryCommand(IUserInterface userInterface, FileManagerLogic fileManager)
        {
            _userInterface = userInterface;
            this.fileManager = fileManager;
        }

        /// <summary>
        /// Переопределенный свойства, содержимое о команде
        /// </summary>
        public override string Description => "Создание директорий (или папок)";

        /// <summary>
        /// Переопределенный метод, для выполнение команд при ввода
        /// </summary>
        /// <param name="args">строка ввода команд</param>
        public override void Execute(string[] args)
        {
             if (args.Length==1)
             {
                 _userInterface.WriteLine("Путь к директорий пуста. Введите путь директорий");
                 return;
             }
            var dir_path = args[1];
            DirectoryInfo? directory = new DirectoryInfo(dir_path);

            if(!directory.Exists)
            {
                directory.Create();
                _userInterface.WriteLine("директорий создана!");
            }
            else
            {
                _userInterface.WriteLine($"Директорий {directory} существует! Повторите ещё раз");
            }
        }
    }
