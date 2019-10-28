PROJECT = kjb
LIBRARY = $(PROJECT).dylib

BIN_DIR = bin
LIB_DIR = lib
SRC_DIR = src
TST_DIR = test
HDR_DIR = include
3PT_DIR = 3rd_party

TST_SRC = \
	$(TST_DIR)/test.cpp

LIB_SRC = \
	$(SRC_DIR)/img.cpp \
	$(SRC_DIR)/kjb.cpp \
	$(SRC_DIR)/msg.cpp

OBJ_SRC = \
	$(addprefix $(LIB_DIR)/, $(notdir $(LIB_SRC:.cpp=.o)))

CXXFLAGS += -std=c++11

$(OBJ_SRC):
	$(CXX) $(CXXFLAGS) -fPIC -c -I$(HDR_DIR) -I$(3PT_DIR) -o $@ $(addprefix $(SRC_DIR)/, $(notdir $(@:.o=.cpp)))

.PHONY: library test release debug clean run

library:
	$(CXX) -shared -o $(LIB_DIR)/$(LIBRARY) -fPIC $(OBJ_SRC)
test:
	$(CXX) $(CXXFLAGS) -I$(HDR_DIR) -L$(LIB_DIR) -o $(BIN_DIR)/$(PROJECT)_test $(TST_SRC) $(LIB_DIR)/$(LIBRARY)

release: CXXFLAGS += -O3
release: clean $(OBJ_SRC) library test

debug: CXXFLAGS += -g
debug: clean $(OBJ_SRC) library test

run:
	./$(BIN_DIR)/$(PROJECT)_test

clean:
	rm -rf $(OBJ_SRC) $(LIB_DIR)/$(LIBRARY) $(BIN_DIR)/$(PROJECT)_test
