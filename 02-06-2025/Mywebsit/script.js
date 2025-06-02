function showMessage() 
{
  alert("Hello! Thanks for clicking the button.");
}

function handleForm(event)
 {
  event.preventDefault();
  const name = document.getElementById("name").value;
  alert(`Thank you, ${name}, your message has been sent!`);
}


