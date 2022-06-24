# --------------- DÉBUT COUCHE OS -------------------
FROM debian:latest
# --------------- FIN COUCHE OS ---------------------


# MÉTADONNÉES DE L'IMAGE
LABEL version="1.17" maintainer="PetitVulcan"


# VARIABLES TEMPORAIRES
ARG APT_FLAGS="-q -y"
ARG DOCUMENTROOT="/data"



# --------------- DÉBUT COUCHE Java ---------------
RUN apt-get update -y && apt-get upgrade -y && apt-get install ${APT_FLAGS} default-jdk
# --------------- FIN COUCHE Java -----------------



# --------------- DÉBUT COUCHE Minecraft ----------------
COPY MinecraftServer_V1_16_5/ /
# --------------- FIN COUCHE minecraft ------------------



# OUVERTURE DU PORT MINECRAFT
EXPOSE 25565


# RÉPERTOIRE DE TRAVAIL
WORKDIR  ${DOCUMENTROOT}


# DÉMARRAGE DES SERVICES LORS DE L'EXÉCUTION DE L'IMAGE
ENTRYPOINT java -Xms1024M -Xmx1024M -jar server.jar nogui -D FOREGROUND