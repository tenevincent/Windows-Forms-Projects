using AutoMapper;
using Employees.App.Services.Profiles;
using Employees.UI.Profiles;
using MediatR;
using System.Windows.Forms;

namespace Employees.UI
{
    public partial class MainForm : Form
    {
        public MainForm(IMapper mapper, IMediator mediator)
        {
            InitializeComponent();

            var foo = new FooDto();
            FooDto foodto = mapper.Map<FooDto>(foo);

            var order = new OrderDto();
            OrderDto orderdto = mapper.Map<OrderDto>(order);

        }

    }
}
