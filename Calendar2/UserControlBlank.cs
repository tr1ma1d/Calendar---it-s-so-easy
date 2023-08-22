using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar2
{
    public partial class UserControlBlank : Component
    {
        public UserControlBlank()
        {
            InitializeComponent();
        }

        public UserControlBlank(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
