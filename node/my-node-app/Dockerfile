# FROM Directive -  means we are selecting imagesa from base or docker hub https://hub.docker.com/_/node
FROM node:21-alpine3.18

#copy directive used to  copy individual file or directive innto container to get file and build image
COPY package.json /app/
COPY app.js /app/

# working directry where we store all  things
WORKDIR /app

# RUN Directive used to  install ithe dependecies inside the containnr
RUN npm install

#CMD always last command which used to run the image
CMD ["node", "app.js"]



# Basic comment from onne github acc https://gitlab.com/nanuchi/docker-in-1-hour
# FROM node:19-alpine

# # Copy package.json, wildcard used so both package.json AND package-lock.json are copied
# # slash '/' at the end of app is important, so it created an app directory, otherwise you'll get an error
# COPY package*.json /usr/app/

# # Copy app files from src directory
# COPY src /usr/app/

# # Create app directory & set default dir so that next commands executes in /usr/app dir, liked cd-ing into /usr/app to execute npm install
# WORKDIR /usr/app

# # Install app dependencies
# RUN npm install

# # Start the application
# CMD ["node", "server.js"]
