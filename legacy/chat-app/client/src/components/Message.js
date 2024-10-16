import React from 'react';

const Message = ({ sender, content }) => {
  return (
    <div className="message">
      <span className="sender">{sender}</span>
      <p className="content">{content}</p>
    </div>
  );
};

export default Message;