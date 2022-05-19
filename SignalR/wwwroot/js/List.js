console.log("im in list ");


var con = new signalR.HubConnectionBuilder().withUrl("/EmpHub").build();


//connection 
async function start() {
    try {
        await con.start();
        console.log("SignalR Connected.");
    } catch (err) {
        console.log(err);
        setTimeout(start, 5000);
    }
};

//start con 
start();


con.on("NewEmp", (emp) => {
    console.log(emp);
    document.getElementById("tableBody").innerHTML += `

            <tr>
            <td>
              ${emp.name}
            </td>
            <td>
                  ${emp.job}
            </td>

        </tr>
`

})