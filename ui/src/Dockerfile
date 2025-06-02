FROM node:slim as builder
COPY package.json package-lock.json ./
RUN npm set progress=true && npm config set depth 0 && npm cache clean --force
RUN npm i && mkdir /ng-app && cp -R ./node_modules ./ng-app
WORKDIR /ng-app
COPY . .
RUN $(npm bin)/ng build

FROM nginx:1.17.4-alpine as app
EXPOSE 8080
RUN rm -rf /etc/nginx/conf.d/default.conf
COPY --from=builder /ng-app/nginx/*.conf /etc/nginx/conf.d/
RUN rm -rf /usr/share/nginx/html/*
COPY --from=builder /ng-app/dist/ecommerce-ui /usr/share/nginx/html
CMD ["nginx", "-g", "daemon off;"]
