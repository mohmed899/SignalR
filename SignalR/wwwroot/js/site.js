var  con = new signalR.HubConnectionBuilder().withUrl("/EmpHub").build();


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

//send employee


function send() {
    

    var emp = {
        Name: document.getElementById("nameIn").value,
        job: document.getElementById("jobIn").value
    };

     con.invoke("AddEmployee", emp);
}










// start con 
start();