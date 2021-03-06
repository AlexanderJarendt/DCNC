﻿using System;
using AreaServer.Database;
using AreaServer.Util;
using Shared;
using Shared.Network;
using Shared.Util;

namespace AreaServer
{
    public class AreaServer : ServerMain
    {
        public static readonly AreaServer Instance = new AreaServer();

        private bool _running;

        /// <summary>
        ///     Initializes fields and properties
        /// </summary>
        private AreaServer()
        {
        }

        /// <summary>
        ///     Instance of the actual server component.
        /// </summary>
        public DefaultServer Server { get; set; }

        /// <summary>
        ///     Database
        /// </summary>
        public AreaDatabase Database { get; private set; }

        /// <summary>
        ///     Configuration
        /// </summary>
        private AreaConf Config { get; set; }

        /// <summary>
        ///     Loads all necessary components and starts the server.
        /// </summary>
        public void Run()
        {
            if (_running)
                throw new Exception("Server is already running.");

            int x, y, width, height;
            Win32.GetWindowPosition(out x, out y, out width, out height);
            Win32.SetWindowPosition(width + 5, height + 5, width, height);

            ConsoleUtil.WriteHeader($"Area Server ({Shared.Util.Version.GetVersion()})", ConsoleColor.DarkGreen);
            ConsoleUtil.LoadingTitle();

            Log.Info("Server startup requested");
            Log.Info($"Server Version {Shared.Util.Version.GetVersion()}");

            NavigateToRoot();

            // Conf
            LoadConf(Config = new AreaConf());

            // Database
            InitDatabase(Database = new AreaDatabase(), Config);

            // Start
            Server = new DefaultServer(Config.Area.Port, false);
            Server.Start();

            var server2 = new DefaultServer(11041, false);
            server2.Start();

            ConsoleUtil.RunningTitle();
            _running = true;
            
            Log.Info("Registering commands...");

            // Commands
            var commands = new AreaConsoleCommands();
            commands.Wait();
            
            Log.Info("Finished starting up server!");
        }
    }
}