import requests

# create a data dictionary with the chat_id, user_id, message_text, and chat_history
data = {
    "chat_id": 1,
    "user_id": 2,
    "message_text": "Hello",
    "chat_history": "",  # Make sure this is a string, not a list
    "api_key": "Ql4svt2Nb5a9yAYQCk1u9lIyE"
}

# make a POST request to your API server with the data
#response = requests.post("https://89.22.107.179/api/process_message", json=data)
response = requests.post("https://mm29942.com/api/process_message", json=data)
# print the response data as a string
print(response.text)
