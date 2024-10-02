FROM lexdrel/dotnet8:ubuntu24

# Update package list and upgrade existing packages
RUN apt-get update && apt-get upgrade -y

# Receive the developer user's UID and USER:
ARG DEVELOPER_UID=1000
ARG DEVELOPER_USERNAME=you

# Remove the existing user 'ubuntu'
RUN userdel -r ubuntu

# Receive the developer user's UID and USER:
ARG DEVELOPER_UID=1000
ARG DEVELOPER_USERNAME=you
    
# Replicate the developer user in the development image:
RUN groupadd --gid ${DEVELOPER_UID} ${DEVELOPER_USERNAME} \
    ;  useradd -r -m -u ${DEVELOPER_UID} --gid ${DEVELOPER_UID} \
    --shell /bin/bash -c "Developer User,,," ${DEVELOPER_USERNAME}

# Ensure that the home directory, the app path and bundler directories are owned
# by the developer user:z
# (A workaround to a side effect of setting WORKDIR before creating the user)
RUN userhome=$(eval echo ~${DEVELOPER_USERNAME}) \
    && chown -R ${DEVELOPER_USERNAME}:${DEVELOPER_USERNAME} $userhome \
    && mkdir -p /workspaces/${localWorkspaceFolderBasename} \
    && chown -R ${DEVELOPER_USERNAME}:${DEVELOPER_USERNAME} /workspaces/${localWorkspaceFolderBasename}
