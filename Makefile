EXEC = kjb

BIN_DIR = ./bin
LIB_DIR = ./lib
SRC_DIR = ./src
HDR_DIR = ./include
3RD_DIR = ./3rd_party

TSRC= \
	$(SRC_DIR)/test.cpp

LSRC= \
	$(SRC_DIR)/img.cpp \
	$(SRC_DIR)/kjb.cpp \
	$(SRC_DIR)/msg.cpp

CXXFLAGS +=-std=c++11

RFLAGS = $(CXXFLAGS) -O3 -L$(LIB_DIR)
DFLAGS = $(CXXFLAGS) -g  -L$(LIB_DIR)

LRFLAGS = $(CXXFLAGS) $(RFLAGS) -dynamiclib
LDFLAGS = $(CXXFLAGS) $(DFLAGS) -dynamiclib

release:
	$(CXX) $(LRFLAGS) -I$(HDR_DIR) -I$(3RD_DIR) -o $(LIB_DIR)/$(EXEC).dylib $(LSRC)
	$(CXX) $(RFLAGS)  -I$(HDR_DIR) -I$(3RD_DIR) -o $(BIN_DIR)/$(EXEC) $(TSRC) $(LIB_DIR)/$(EXEC).dylib
debug:
	$(CXX) $(LDFLAGS) -I$(HDR_DIR) -I$(3RD_DIR) -o $(LIB_DIR)/$(EXEC).dylib $(LSRC)
	$(CXX) $(DFLAGS)  -I$(HDR_DIR) -I$(3RD_DIR) -o $(BIN_DIR)/$(EXEC) $(TSRC) $(LIB_DIR)/$(EXEC).dylib

run:
	./$(BIN_DIR)/$(EXEC)