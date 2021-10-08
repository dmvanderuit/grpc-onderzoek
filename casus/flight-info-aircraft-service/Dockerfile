FROM node:alpine

EXPOSE 50051

WORKDIR app

COPY package.json .
RUN npm install \
    && npm install typescript -g

COPY . .

RUN tsc

CMD ["node", "./dist/index.js"]