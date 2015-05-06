using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsolationFramework_Chapter5
{
    public class Presenter
    {
        IView view;
        private IView viewStub;
        private IWebService serviceMock;

        public Presenter(IView view)
        {
            this.view = view;
            this.view.Load += new EventHandler(view_Load);
        }

        public Presenter(IView viewStub, IWebService serviceMock)
        {
            this.viewStub = viewStub;
            this.serviceMock = serviceMock;
        }

        void view_Load(object sender, EventArgs e)
        {
            throw new Exception("Not implemented.");
        }
    }
}
