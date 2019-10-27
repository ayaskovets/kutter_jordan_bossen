PROJ = kjb

BIN_DIR = ./bin
LIB_DIR = ./lib
SRC_DIR = ./src
TST_DIR = ./test
HDR_DIR = ./include
3RD_DIR = ./3rd_party

TSRC= \
	$(TST_DIR)/test.cpp

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
	$(CXX) $(LRFLAGS) -I$(HDR_DIR) -I$(3RD_DIR) -o $(LIB_DIR)/$(PROJ).dylib $(LSRC)
	$(CXX) $(RFLAGS)  -I$(HDR_DIR) -I$(3RD_DIR) -o $(BIN_DIR)/$(PROJ)_test $(TSRC) $(LIB_DIR)/$(PROJ).dylib
debug:
	$(CXX) $(LDFLAGS) -I$(HDR_DIR) -I$(3RD_DIR) -o $(LIB_DIR)/$(PROJ).dylib $(LSRC)
	$(CXX) $(DFLAGS)  -I$(HDR_DIR) -I$(3RD_DIR) -o $(BIN_DIR)/$(PROJ)_test $(TSRC) $(LIB_DIR)/$(PROJ).dylib

run:
	./$(BIN_DIR)/$(PROJ)_test