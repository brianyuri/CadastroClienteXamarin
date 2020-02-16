const {getDatabase} = require('./mongo');
const {ObjectID} = require('mongodb');

const collectionName = 'cliente';

async function insertCliente(cliente) {
  const database = await getDatabase();
  const {insertedId} = await database.collection(collectionName).insertOne(cliente);
  return insertedId;
}

async function getClientes() {
  const database = await getDatabase();
  return await database.collection(collectionName).find({}).toArray();
}

async function deleteCliente(id) {
  const database = await getDatabase();
  await database.collection(collectionName).deleteOne({
    _id: new ObjectID(id),
  });
}

async function updateCliente(id, cliente) {
  const database = await getDatabase();
  delete cliente._id;
  await database.collection(collectionName).update(
    { _id: new ObjectID(id), },
    {
      $set: {
        ...cliente,
      },
    },
  );
}

module.exports = {
  insertCliente,
  getClientes,
  deleteCliente,
  updateCliente,
};
