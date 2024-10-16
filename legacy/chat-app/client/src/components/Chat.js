import React, { useState, useEffect } from 'react';
import Message from './Message';

const Chat = () => {
  const [messages, setMessages] = useState([]);
  const [inputValue, setInputValue] = useState('');

  const handleInputChange = (event) => {
    setInputValue(event.target.value);
  };

  const handleSendMessage = () => {
    if (inputValue.trim() !== '') {
      const newMessage = {
        id: messages.length + 1,
        text: inputValue,
      };

      setMessages([...messages, newMessage]);
      setInputValue('');
    }
  };

  useEffect(() => {
    // Simulate receiving messages from the server
    const receivedMessages = [
      { id: 1, text: 'Hello' },
      { id: 2, text: 'How are you?' },
    ];

    setMessages(receivedMessages);
  }, []);

  return (
    <div>
      <div>
        {messages.map((message) => (
          <Message key={message.id} text={message.text} />
        ))}
      </div>
      <div>
        <input type="text" value={inputValue} onChange={handleInputChange} />
        <button onClick={handleSendMessage}>Send</button>
      </div>
    </div>
  );
};

export default Chat;