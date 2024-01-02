import configparser
import os

def list_aws_profiles():
    config = configparser.ConfigParser()
    config.read(os.path.expanduser('~/.aws/credentials'))
    return config.sections()

print(list_aws_profiles())