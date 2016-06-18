'use strict';
const express = require('express');
const app = express();

app.get('/hello', (req, res) => {
  res.send('world');
});

app.get('/hello-json', (req, res) => {
  res.json({
    hello: 'world'
  });
});

app.listen(process.env.PORT, function () {
  console.log('READY');
});