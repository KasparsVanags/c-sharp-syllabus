#!/bin/bash

docker run --rm -it -v `pwd`:/repo -p 9000:9000 gitpitch/desktop:pro
