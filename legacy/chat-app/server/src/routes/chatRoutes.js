const express = require('express');
const router = express.Router();

// Define routes for chat functionality
router.get('/chat', (req, res) => {
  // Handle GET request for chat
  res.send('This is the chat route');
});

router.post('/chat', (req, res) => {
  // Handle POST request for chat
  const message = req.body.message;
  // Process the message and send a response
  res.send(`Received message: ${message}`);
});

module.exports = router;