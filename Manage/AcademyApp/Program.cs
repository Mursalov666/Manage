﻿using Core.Constants;
using Core.Entities;
using Core.Helpers;
using DataAccess.Repositories.Implementations;
using Manage.Controllers;

namespace Manage
{
    public class Program
    {
        static void Main()
        {
            GroupRepository _groupRepository = new GroupRepository();
            GroupController groupController = new GroupController();

            ConsoleHelper.WriteTextWithColor(ConsoleColor.Green, "Welcome :)");

            Console.WriteLine("*************");
            while (true)
            {

                ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, "1 - Create Group");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, "2 - Update Group");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, "3 - Delete Group");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, "4 - All Groups");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, "5 - Get Group by name");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Cyan, "0 - Exit");
                Console.WriteLine("*************");
                ConsoleHelper.WriteTextWithColor(ConsoleColor.Blue, "Select Option");
                string number = Console.ReadLine();

                int SelectedNumber;
                bool result = int.TryParse(number, out SelectedNumber);
                if (result)
                {
                    if (SelectedNumber >= 0 && SelectedNumber <= 5)
                    {
                        switch (SelectedNumber)
                        {
                            case (int)Options.CreateGroup:
                                groupController.CreateGroup();
                                break;
                            case (int)Options.UpdateGroup:
                                groupController.UpdateGroup();
                                break;
                            case (int)Options.DeleteGroup:
                                groupController.DeleteGroup();
                                break;
                            case (int)Options.AllGroups:
                                groupController.AllGroups();
                                break;
                            case (int)Options.GetGroupByName:
                                groupController.GetGroupName();
                                break;
                            case (int)Options.Exit:
                                groupController.Exit();
                                break;

                        }
                    }
                    else
                    {
                        ConsoleHelper.WriteTextWithColor(ConsoleColor.Red, "Entered wrong number");

                    }
                }
                else
                {
                    ConsoleHelper.WriteTextWithColor(ConsoleColor.Red, "Enter number !");
                }
            }



        }
    }
}