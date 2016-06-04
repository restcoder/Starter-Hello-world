'use strict';

var express = require('express');
var app = express();

app.get("/hello", (req, res) => res.end("world"));

app.listen(process.env.PORT, function () {
    console.log('Listening on', process.env.PORT);
    console.log('READY');
});