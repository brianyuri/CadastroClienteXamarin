// ./src/index.js

//importing the dependencies
const express = require('express');
const bodyParser = require('body-parser');
const cors = require('cors');
const helmet = require('helmet');
const morgan = require('morgan');
const {startDatabase} = require('./database/mongo');
const {insertCliente, getClientes, deleteCliente, updateCliente} = require('./database/cliente');
// defining the Express app
const app = express();

// adding Helmet to enhance your API's security
app.use(helmet());

// using bodyParser to parse JSON bodies into JS objects
app.use(bodyParser.json());

// enabling CORS for all requests (not very secure)
app.use(cors());

// adding morgan to log HTTP requests
app.use(morgan('combined'));

// endpoint to return all ads
app.get('/', async (req, res) => {
  res.send(await getClientes());
});

app.post('/', async (req, res) => {
  const newAd = req.body;
  await insertCliente(newAd);
  res.send({ message: 'New ad inserted.' });
});

// endpoint to delete an ad
app.delete('/:id', async (req, res) => {
  await deleteCliente(req.params.id);
  res.send({ message: 'Ad removed.' });
});

// endpoint to update an ad
app.put('/:id', async (req, res) => {
  const updatedAd = req.body;
  await updateCliente(req.params.id, updatedAd);
  res.send({ message: 'Ad updated.' });
});

// start the in-memory MongoDB instance
startDatabase().then(async () => {
  await insertCliente({title: 'Hello, now from the in-memory database!'});

  // start the server
  app.listen(3001, async () => {
    console.log('listening on port 3001');
  });
});
