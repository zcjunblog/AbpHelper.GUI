﻿using JetBrains.Annotations;

namespace EasyAbp.AbpHelper.Gui.Services.AbpCli.New.Dtos
{
    public class AbpNewConsoleInput : AbpNewInput
    {
        public override string Template { get; } = "module";

        public AbpNewConsoleInput()
        {

        }

        public AbpNewConsoleInput([NotNull] string solutionName, [NotNull] string outputFolder,
            [CanBeNull] string version, bool preview, [CanBeNull] string templateSource, bool createSolutionFolder,
            [CanBeNull] string connectionString, Database databaseManagementSystem,
            [CanBeNull] string localFrameworkRef, bool noRandomPort, string template, bool noUi) : base(solutionName,
            outputFolder, version, preview, templateSource, createSolutionFolder, connectionString,
            databaseManagementSystem, localFrameworkRef, noRandomPort)
        {
            Template = template;
        }
    }
}
