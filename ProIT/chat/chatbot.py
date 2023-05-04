import argparse
import openai
import psycopg2
from langchain.chat_models import ChatOpenAI
from langchain import PromptTemplate, LLMChain
from langchain.prompts.chat import (
    ChatPromptTemplate,
    SystemMessagePromptTemplate,
    HumanMessagePromptTemplate,
)
from langchain.schema import (
    HumanMessage,
    SystemMessage
)

# Make sure to set your OpenAI API key
openai.api_key = "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"

class ChatDavinci003(ChatOpenAI):
    def run(self, *args, **kwargs):
        response = openai.Completion.create(
            engine="text-davinci-003",
            prompt=kwargs['prompt'],
            max_tokens=2048,
            **kwargs
        )
        return response.choices[0].text.strip()

chat_model = ChatDavinci003(temperature=0.5)  # Adjust the temperature as needed

# Database connection
connection = psycopg2.connect(
    dbname="memory",
    user="mm29942",
    password="Mm31415926535",  # Replace with your actual password
    host="localhost",
    port="5432"  # The default PostgreSQL port
)

template = "you are a process helper to find and ascertain the best applicant for our job offer"
system_message_prompt = SystemMessagePromptTemplate.from_template(template)

human_template="{content}"
human_message_prompt = HumanMessagePromptTemplate.from_template(human_template)

def create_chat():
    with connection.cursor() as cursor:
        cursor.execute("INSERT INTO chats (chat_name) VALUES ('New Chat') RETURNING chat_id")
        chat_id = cursor.fetchone()[0]
        connection.commit()
        return chat_id

def chat_function(chat_id, user_id, message):
    human_message = HumanMessage(content=message)
    chat_prompt = ChatPromptTemplate.from_messages([system_message_prompt, human_message])
    chain = LLMChain(llm=chat_model, prompt=chat_prompt.to_prompt())
    response = chain.run()

    # Store message and response in the messages table
    with connection.cursor() as cursor:
        cursor.execute(
            "INSERT INTO messages (chat_id, user_id, message_text) VALUES (%s, %s, %s)",
            (chat_id, user_id, message)
        )
        cursor.execute(
            "INSERT INTO messages (chat_id, user_id, message_text) VALUES (%s, NULL, %s)",
            (chat_id, response)
        )
        connection.commit()

    return response


def main():
    parser = argparse.ArgumentParser(description='Chat script')
    parser.add_argument('-c', '--chat_id', type=int, help='Chat ID')
    parser.add_argument('-u', '--user_id', type=int, default=1, help='User ID')
    args = parser.parse_args()

    if args.chat_id is None:
        args.chat_id = create_chat()
        print(f'New chat created with ID {args.chat_id}')

    user_input = input("> ")
    response = chat_function(args.chat_id, args.user_id, user_input)
    print(response)

    # Close the connection to the database
    connection.close()

if __name__ == '__main__':
    main()
