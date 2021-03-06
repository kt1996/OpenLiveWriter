// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.

using System.ComponentModel;
using OpenLiveWriter.ApplicationFramework;

namespace OpenLiveWriter.PostEditor.Commands
{
    /// <summary>
    /// Summary description for CommandClose.
    /// </summary>
    public class CommandPostAndPublish : Command
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        public CommandPostAndPublish(IContainer container)
        {
            ///
            /// Required for Windows.Forms Class Composition Designer support
            ///
            InitializeComponent();

            //
            //
            //
        }

        public CommandPostAndPublish()
        {
            ///
            /// Required for Windows.Forms Class Composition Designer support
            ///
            InitializeComponent();

            //
            //
            //
        }

        #region Component Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            //
            // CommandPostAndPublish
            //
            this.CommandBarButtonText = "Publish";
            this.ContextMenuPath = "-P&ublish to Weblog@100";
            this.Identifier = "OpenLiveWriter.PostAndPublish";
            this.MainMenuPath = "&File@0/-P&ublish to Weblog@100";
            this.MenuText = "P&ublish to Weblog";
            this.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.Text = "Publish to Weblog";

        }
        #endregion
    }
}
