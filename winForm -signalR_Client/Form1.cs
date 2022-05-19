using Microsoft.AspNetCore.SignalR.Client;
using winForm__signalR_Client.Models;
namespace winForm__signalR_Client
{
    public partial class Form1 : Form
    {   List<Employee> employees;
        HubConnection con;
        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                // create connection 
                con  = new HubConnectionBuilder().WithUrl("http://localhost:5050/EmpHub").Build();

               // stablish the connection 
                con.StartAsync();


            //invoke get all emps 
              con.InvokeAsync("getEmployees");

            //subscrib  get new emp 
            con.On<Employee>("NewEmp", (emp) =>
            {
                employees.Add(emp);

                DGV_Emp.DataSource = null;
                DGV_Emp.DataSource= employees;
            });

            // get all emps on load
            con.On<List<Employee>>("GetAllEmployee", (emps) =>
            {
                employees = emps;
                DGV_Emp.DataSource = null;
                DGV_Emp.DataSource = emps;
            }); 

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            con.InvokeAsync("AddEmployee", new Employee() { Name = TxtName.Text, job = TxtJob.Text });
        }



        //void GetEmplye

    }
}