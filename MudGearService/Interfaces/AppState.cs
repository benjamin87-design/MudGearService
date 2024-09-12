using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudGearService.Interfaces
{
    public class AppState
    {
        private bool _loggedIn;
        private string _useremail;
        public event Action OnChange;
        public bool LoggedIn
        {
            get { return _loggedIn; }
            set
            {
                if (_loggedIn != value)
                {
                    _loggedIn = value;
                    NotifyStateChanged();
                }
            }
        }
        public string UserEmail
        {
            get { return _useremail; }
            set
            {
                if (_useremail != value)
                {
                    _useremail = value;
                    NotifyStateChanged();
                }
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}
