using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScMaSy_ice.Views.Interfaces
{
    public interface IUserView
    {
        // Proprieties
        int UserId { get; set; }
        string UserCode { get; set; }
        string UserLastname { get; set; }
        string UserFirstname { get; set; }
        string Username { get; set; }
        string UserPassword { get; set; }
        string UserStatus { get; set; }
        string UserRole { get; set; }
        DateTime UserCreatedAt { get; set; }
        string UserCreatedBy { get; set; }
        DateTime UserDeletedAt { get; set; }

        string SearchValue { get; set; }
        bool isEdit { get; set; }
        bool isSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler AddUserEvent;
        event EventHandler EditUserEvent;
        event EventHandler DeleteUserEvent;
        event EventHandler SaveUserEvent;
        event EventHandler CancelEvent;

        // Methods
        void SetUserListBindingSource(BindingSource userList);
        void Show();
    }
}
