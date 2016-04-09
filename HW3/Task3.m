function [ Q, rec ] = Task3( epsilon, alpha, gamma, episode )
%TASK3 Summary of this function goes here
%   Detailed explanation goes here



steps = 20;
mapSize = [10; 5]; 
goalS = [10;4];
rtf = [1;0];
upf = [0;-1];
ltf = [-1;0];   
dnf = [0;1];
stay = [0;0];
A = [rtf upf ltf dnf stay];
X = 1;
Y = 2;

% initial Q table (xD, yD, actionD)
Q = ones(mapSize(Y), mapSize(X),  length(A)) * 50; 
for x = 1 : mapSize(X)
    for y = 1 : mapSize(Y)
        for a  = 1 : length(A)
            Q(y,x,a) = Q(y,x,a) + rand;
        end
    end
end
Q(:,mapSize(X),1) = 0;%right
Q(1,:,2) = 0; %up
Q(:,1,3) = 0; %left
Q(mapSize(Y),:,4) = 0;%down


% rec_step = [];
for learn = 1 : episode
    S = [randi(mapSize(X));randi(mapSize(Y))]; % initital state [x; y]

    for st = 1: steps
        prob_action = [Q(S(Y),S(X),1); Q(S(Y),S(X),2); Q(S(Y),S(X),3); Q(S(Y),S(X),4); Q(S(Y),S(X),5)]; % construct action probability Qector     
        
        Qerify = -1;
        while(Qerify<0)
            a = PickAction(prob_action, epsilon); % Pick an action based on the probability of actions
            Qerify = Constrain( S, A(:,a), mapSize ); % Qerify if state+action is illegal(in-map)
            %prob_action(a) = 0; %remoQe this action because it is illegal
        end
        
        newS = S + A(:,a);
        
%         Q(S(Y),S(X),a) = Q(S(Y),S(X),a) + alpha * (100-(st) - Q(S(Y),S(X),a));
%         100-(sum(abs(newS-goalS)))
        Q(S(Y),S(X),a) = Q(S(Y),S(X),a) + alpha * (Reward(S)+ (gamma*(max(Q(newS(Y),newS(X),:)))) - Q(S(Y),S(X),a));
        
        if(Q(S(Y),S(X),a)<1)
            Q(S(Y),S(X),a) =rand ;
        end
        rec(learn,1) = -st/(sum(abs(newS-goalS))+1);
        S = newS; % update current state
        if(S ==goalS)
            st = steps;
            rec(learn,1) = 100-st/(sum(abs(newS-goalS))+1);
        end
        
    end
%     rec_step(learn) = R;
end
end

