version: '3.8'

services:
  postgres:
    image: postgres:17-alpine
    restart: always
    environment:
      POSTGRES_USER: "postgres"
      POSTGRES_PASSWORD: "Quickrun.App@2025#!"
      POSTGRES_DB: "internal"
    ports:
      - "5432:5432"
