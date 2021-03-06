/**
    This file is part of QuIDE.

    QuIDE - The Quantum IDE
    Copyright (C) 2014  Joanna Patrzyk, Bartłomiej Patrzyk

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Technewlogic.WpfDialogManagement.Contracts
{
	public interface IDialogManager
	{
		IMessageDialog CreateMessageDialog(string message, DialogMode dialogMode);
		IMessageDialog CreateMessageDialog(string message, string caption, DialogMode dialogMode);

		ICustomContentDialog CreateCustomContentDialog(object content, DialogMode dialogMode);
		ICustomContentDialog CreateCustomContentDialog(object content, string caption, DialogMode dialogMode);

		IProgressDialog CreateProgressDialog(DialogMode dialogMode);
		IProgressDialog CreateProgressDialog(string message, DialogMode dialogMode);
		IProgressDialog CreateProgressDialog(string message, string readyMessage, DialogMode dialogMode);

		IWaitDialog CreateWaitDialog(DialogMode dialogMode);
		IWaitDialog CreateWaitDialog(string message, DialogMode dialogMode);
		IWaitDialog CreateWaitDialog(string message, string readyMessage, DialogMode dialogMode);
	}
}