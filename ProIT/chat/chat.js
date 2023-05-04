// Create a data object with the chat_id, user_id, message_text, and chat_history
const data = {
    chat_id: 1,
    user_id: 2,
    message_text: "Hello",
    chat_history: "", // Make sure this is a string, not a list
    api_key: "Ql4svt2Nb5a9yAYQCk1u9lIyE"
  };
  
  // Make a POST request to your API server with the data
  fetch("https://huntercorp.org/api/process_message", {
    method: "POST",
    headers: {
      "Content-Type": "application/json"
    },
    body: JSON.stringify(data)
  })
    .then(response => response.text())
    .then(responseText => {
      // Print the response data as a string
      console.log(responseText);
    })
    .catch(error => {
      console.error("Error:", error);
    });
  