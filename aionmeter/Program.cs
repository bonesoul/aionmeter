﻿/* 
AIONMeter is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

AIONMeter is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with AIONMeter.  If not, see <http://www.gnu.org/licenses/>.

Hüseyin Uslu, <shalafiraistlin nospam gmail dot com> 
*/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace AIONMeter
{
    static class Program
    {
        public static frmMeter main_window;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Try to switch to configured locale
            try { Thread.CurrentThread.CurrentUICulture = new CultureInfo(Config.get_language()); }
            catch (Exception e)
            {
                MessageBox.Show("The language " + Config.get_language() + " couldn't be loaded. Reverting culture to en-US.", "Language Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Config.set_language("en-US");
            }

            Config.set_application_path(Application.StartupPath);
            Updater.check(false); // check for updates

            if (!Config.settings_upgraded())
                Config.upgrade_settings();

            if (!Config.game_path_exists()) // if AION path is not configured yet, do so
            {
                MessageBox.Show("Please set the path for your AION installation", "Need AION path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                frmConfig cfg = new frmConfig();
                cfg.ShowDialog();
            }

            main_window = new frmMeter();
            Application.Run(main_window);
        }
    }
}
