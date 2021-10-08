import { Client } from "pg";
import * as fs from "fs";
import { DatabaseAircraft } from "./models/DatabaseAircraft";
import { Aircraft } from "./models/Aircraft";

let dbClient = null;

function sleep(ms) {
  return new Promise((resolve) => {
    setTimeout(resolve, ms);
  });
}

const connectToDb = async () => {
  dbClient = new Client({
    user: process.env.DB_USER || "postgres",
    database: process.env.DB_NAME || "aircraft_db",
    host: process.env.DB_HOST || "localhost",
    password: process.env.DB_PASSWORD || "mysecretpassword",
    port: parseInt(process.env.DB_PORT) || 54320,
  });

  for (let i = 1; i <= 10; i++) {
    try {
      await dbClient.connect();
      break;
    } catch (e) {
      console.log(`Connection to database failed. Attempt (${i} of 10)`);
      await sleep(5000);
      if (i === 10) {
        throw e;
      }
    }
  }
};

const seedDb = async () => {
  const seedScript = fs.readFileSync("seed.sql").toString();
  await dbClient.query(seedScript);
};

const getAllAircraft = async () => {
  const { rows } = await dbClient.query("SELECT * FROM aircraft");

  const aircraft: Aircraft[] = rows.map((da: DatabaseAircraft) => ({
    Id: da.id,
    Model: da.model,
    Capacity: da.capacity,
    Status: da.status,
    FlightNumber: da.flight_number,
  }));

  return aircraft;
};

const startApplication = async () => {
  try {
    await connectToDb();
    await seedDb();
  } catch (e) {
    console.log("Error connecting to database");
    throw e;
  }

  const ip = process.env.IP || "127.0.0.1";
  const port = 50051;
};

startApplication().then(() => {
  console.log("Server has started");
});
