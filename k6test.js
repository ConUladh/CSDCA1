import { sleep } from "k6";
import http from "k6/http";

export const options = {
  ext: {
    loadimpact: {
      distribution: {
        "amazon:ie:dublin": { loadZone: "amazon:ie:dublin", percent: 100 },
      },
    },
  },
  stages: [
    { target: 20, duration: "1m" },
    { target: 20, duration: "3m30s" },
    { target: 0, duration: "1m" },
  ],
  thresholds: { http_req_duration: ["p(95)<200"] },
};

export default function main() {
  let response;

  response = http.get("https://bpcalculator20211123213520-staging.azurewebsites.net");

  // Automatically added sleep
  sleep(1);
}