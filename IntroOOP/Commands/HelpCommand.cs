﻿using IntroOOP.Commands.BaseCommand;

namespace IntroOOP.Commands;

public class HelpCommand : FileManagerCommand
{
    #region FIELDS
    private readonly IUserInterface userInterface;

    private readonly FileManagerLogic fileManager;
    #endregion

    /// <summary>
    /// Конструктор с двумя параметрами
    /// </summary>
    /// <param name="userInterface">интерфейс пользователя</param>
    /// <param name="fileManager">логика файлового менеджера</param>
    public HelpCommand(IUserInterface userInterface, FileManagerLogic fileManager)
    {
        this.userInterface = userInterface;
        this.fileManager = fileManager;
    }

    /// <summary>
    /// Переопределенный свойства, содержимое о команде
    /// </summary>
    public override string Description => "Справка о консольных командах";

    /// <summary>
    /// Переопределенный метод, для выполнение команд при ввода
    /// </summary>
    /// <param name="args">строка ввода команд</param>
    public override void Execute(string[] args)
    {
        userInterface.WriteLine("Файловой системе Справка о консольных командах\n");
        foreach (var (name, command) in fileManager.Commands)
        {
            if(name=="listDir" || name=="drives" || name=="rename" || name=="cpfile" || 
                name=="movedir" || name=="movefile")
                userInterface.WriteLine($"Название команд: {name},\tописание: {command.Description}");
            else
                userInterface.WriteLine($"Название команд: {name},\t\tописание: {command.Description}");
        }
    }
}